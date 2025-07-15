using BusinessLogicLayer.DTOs.JournalEntryHeaderDTOs;
using BusinessLogicLayer.DTOs.ResponseDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.IServices
{
    public interface IJournalEntryService
    {
        public Task<ResponseDTO<int>> AddJournalEntryAsync(SaveJournalEntryHeaderDTO journalEntry);
    }
}
