using DataAccessLayer.IRepos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
