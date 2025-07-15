namespace BusinessLogicLayer.IServices
{
    public interface IJournalEntryService
    {
        public Task<ResponseDTO<int>> AddJournalEntryAsync(SaveJournalEntryHeaderDTO journalEntry);
    }
}
