namespace DataAccessLayer.IRepos
{
    public interface IGenericRepo<T> where T : class
    {
        public Task<List<T>> GetAllAsync();
        public Task InsertAsync(T entity);
    }
}
