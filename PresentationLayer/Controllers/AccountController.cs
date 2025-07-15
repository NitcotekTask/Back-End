namespace PresentationLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {

        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet("GetSelectableAccounts")]
        public async Task<IActionResult> GetSelectableAccounts()
        {
            try
            {
                var result = await _accountService.GetSelectableAccountsAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                var error = new ResponseDTO<List<DisplayAccontDTO>>
                {
                    IsSuccess = false,
                    Message = $"An error occurred while retrieving accounts: {ex.Message}",
                    Data = null
                };
                return StatusCode(StatusCodes.Status500InternalServerError, error);
            }
        }

    }
}
