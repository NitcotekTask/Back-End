using AutoMapper;
using BusinessLogicLayer.DTOs.AccountDTOs;
using BusinessLogicLayer.DTOs.JournalEntryDetailsDTOs;
using BusinessLogicLayer.DTOs.JournalEntryHeaderDTOs;
using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.MappingConfig
{
    public class MappingProfile : Profile
    {

        public MappingProfile()
        {

            CreateMap<AccountsChart, DisplayAccontDTO>().ReverseMap();
            CreateMap<SaveJournalEntryDetailsDTO, JournalEntryDetail>().ReverseMap();
            CreateMap<SaveJournalEntryHeaderDTO, JournalEntryHeader>()
            .ForMember(dest => dest.JournalEntryDetails, opt => opt.Ignore())
            .AfterMap((src, dest) =>
            {
                dest.CreatedAt = DateTime.UtcNow;
            })
            .ReverseMap();

        }

    }
}
