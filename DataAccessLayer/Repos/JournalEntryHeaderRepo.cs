using DataAccessLayer.Entities;
using DataAccessLayer.IRepos;

namespace DataAccessLayer.Repos
{
    public class JournalEntryHeaderRepo : GenericRepo<JournalEntryHeader> , IJournalEntryHeaderRepo
    {
        private readonly NitcotekContext _db;
        public JournalEntryHeaderRepo(NitcotekContext db) : base(db)
        {
            _db = db;
        }
    }
}
