namespace DataAccessLayer.UnitOfWorks
{
    public interface IUnitOfWork
    {
        IAccountRepo AccountRepo { get; }
        IJournalEntryDetailsRepo JournalEntryDetailsRepo { get; }
        IJournalEntryHeaderRepo JournalEntryHeaderRepo { get; }
        
        Task<int> SaveAsync();
    }
}
