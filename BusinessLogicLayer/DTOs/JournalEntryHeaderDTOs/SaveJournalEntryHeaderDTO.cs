using BusinessLogicLayer.DTOs.JournalEntryDetailsDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.DTOs.JournalEntryHeaderDTOs
{
    public class SaveJournalEntryHeaderDTO
    {
        public int? EntryNumber { get; set; }
        public DateOnly EntryDate { get; set; }
        public string Description { get; set; } = null!;
        public List<SaveJournalEntryDetailsDTO> Details { get; set; } = new List<SaveJournalEntryDetailsDTO>();
    }
}
