using DataAccessLayer.Entities;
using DataAccessLayer.IRepos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
