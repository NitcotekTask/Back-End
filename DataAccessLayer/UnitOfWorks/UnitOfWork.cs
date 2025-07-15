using DataAccessLayer.Entities;
using DataAccessLayer.IRepos;
using DataAccessLayer.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.UnitOfWorks
{
    public class UnitOfWork
    {
        private readonly NitcotekContext _db;
        public UnitOfWork(NitcotekContext db)
        {
            _db = db;
        }

        private IAccountRepo _AccountRepo;
        private IJournalEntryDetailsRepo _JournalEntryDetailsRepo;
        private IJournalEntryHeaderRepo _JournalEntryRepo;

        public IAccountRepo AccountRepo => _AccountRepo ??= new AccountRepo(_db);
        public IJournalEntryDetailsRepo JournalEntryDetailsRepo => _JournalEntryDetailsRepo ??= new JournalEntryDetailsRepo(_db);
        public IJournalEntryHeaderRepo JournalEntryHeaderRepo => _JournalEntryRepo ??= new JournalEntryHeaderRepo(_db);

        public async Task<int> SaveAsync()
        {
            return await _db.SaveChangesAsync();
        }

    }
}
