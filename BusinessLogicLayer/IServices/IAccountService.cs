namespace BusinessLogicLayer.IServices
{
    public interface IAccountService
    {

        public Task<ResponseDTO<List<DisplayAccontDTO>>> GetSelectableAccountsAsync();

    }
}
