using DataAccessLayer.Entities;
using DataAccessLayer.IRepos;

namespace DataAccessLayer.Repos
{
    public class JournalEntryDetailsRepo : GenericRepo<JournalEntryDetail> , IJournalEntryDetailsRepo
    {
        private readonly NitcotekContext _db;
        public JournalEntryDetailsRepo(NitcotekContext db) : base(db)
        {
            _db = db;
        }
    }
}
