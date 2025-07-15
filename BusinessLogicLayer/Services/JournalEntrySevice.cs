using AutoMapper;
using BusinessLogicLayer.DTOs.JournalEntryHeaderDTOs;
using BusinessLogicLayer.DTOs.ResponseDTOs;
using BusinessLogicLayer.IServices;
using DataAccessLayer.Entities;
using DataAccessLayer.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class JournalEntrySevice : IJournalEntryService
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public JournalEntrySevice(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ResponseDTO<int>> AddJournalEntryAsync(SaveJournalEntryHeaderDTO journalEntry)
        {
            if (journalEntry == null)
            {
                throw new ArgumentNullException("Journal entry cannot be null");
            }

            if (journalEntry.EntryDate == default)
            {
                throw new ArgumentException("Entry date is required");
            }

            if (string.IsNullOrWhiteSpace(journalEntry.Description))
            {
                throw new ArgumentException("Description is required");
            }

            if (journalEntry.Details == null || !journalEntry.Details.Any())
            {
                throw new ArgumentException("At least one journal entry detail is required");
            }

            foreach (var detail in journalEntry.Details)
            {
                if (detail.Debit == 0 && detail.Credit == 0)
                {
                    throw new ArgumentException("Each journal entry detail must have either a debit or credit amount");
                }

                if(detail.Debit != 0 && detail.Credit != 0)
                {
                    throw new ArgumentException("Each journal entry detail must have either a debit or credit amount, not both");
                }
            }

            var totalDebit = journalEntry.Details.Sum(d => d.Debit);
            var totalCredit = journalEntry.Details.Sum(d => d.Credit);

            if (totalDebit != totalCredit)
            {
                throw new InvalidOperationException("Total debit must equal total credit for a journal entry");
            }

            if (journalEntry.EntryNumber.HasValue)
            {
                var existingEntry = await _unitOfWork.JournalEntryHeaderRepo.GetAllAsync();
                if (existingEntry.Any(j => j.EntryNumber == journalEntry.EntryNumber))
                {
                    throw new InvalidOperationException($"Journal entry with number {journalEntry.EntryNumber} already exists");
                }
            }

            var header = _mapper.Map<JournalEntryHeader>(journalEntry);
            await _unitOfWork.JournalEntryHeaderRepo.InsertAsync(header);
            await _unitOfWork.SaveAsync();

            var details = _mapper.Map<List<JournalEntryDetail>>(journalEntry.Details);
            foreach (var detail in details)
            {
                detail.JounalEntryHeaderId = header.Id;
                await _unitOfWork.JournalEntryDetailsRepo.InsertAsync(detail);
            }

            await _unitOfWork.SaveAsync();

            return new ResponseDTO<int>
            {
                IsSuccess = true,
                Message = "Journal entry added successfully",
                Data = header.Id
            };
        }
    }
}
