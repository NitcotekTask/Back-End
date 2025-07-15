using DataAccessLayer.Entities;
using DataAccessLayer.IRepos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
