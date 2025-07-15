using DataAccessLayer.Entities;
using DataAccessLayer.IRepos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repos
{
    public class GenericRepo<T> : IGenericRepo<T> where T : class
    {

        private readonly NitcotekContext _db;
        private readonly DbSet<T> dbSet;

        public GenericRepo(NitcotekContext db)
        {
            _db = db;
            dbSet = _db.Set<T>();
        }


        public async Task<List<T>> GetAllAsync()
        {
            return await dbSet.ToListAsync();
        }

        public async Task InsertAsync (T entity)
        {
            await dbSet.AddAsync(entity);
        }

        public void Delete(T entity)
        {
            dbSet.Remove(entity);
        }

    }
}
