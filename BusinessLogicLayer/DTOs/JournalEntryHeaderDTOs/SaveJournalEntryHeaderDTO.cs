namespace BusinessLogicLayer.DTOs.JournalEntryHeaderDTOs
{
    public class SaveJournalEntryHeaderDTO
    {
        public int? EntryNumber { get; set; }
        public DateTime EntryDate { get; set; }
        public string Description { get; set; } = null!;
        public List<SaveJournalEntryDetailsDTO> Details { get; set; } = new List<SaveJournalEntryDetailsDTO>();
    }
}
