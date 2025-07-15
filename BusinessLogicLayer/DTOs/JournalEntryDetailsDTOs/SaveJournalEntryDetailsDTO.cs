namespace BusinessLogicLayer.DTOs.JournalEntryDetailsDTOs
{
    public class SaveJournalEntryDetailsDTO
    {
        public Guid AccountId { get; set; }
        public decimal Debit { get; set; }
        public decimal Credit { get; set; }
    }
}
