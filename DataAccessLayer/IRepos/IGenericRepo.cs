using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.IRepos
{
    public interface IGenericRepo<T> where T : class
    {

        public Task<List<T>> GetAllAsync();
        public Task InsertAsync(T entity);
        public void Delete(T entity);


    }
}
