namespace DataAccessLayer.Repos
{
    public class AccountRepo : GenericRepo<AccountsChart> , IAccountRepo
    {
        private readonly NitcotekContext _db;
        public AccountRepo(NitcotekContext db) : base(db)
        {
            _db = db;
        }
    }
}
