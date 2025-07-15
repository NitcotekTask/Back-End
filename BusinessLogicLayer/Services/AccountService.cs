namespace BusinessLogicLayer.Services
{
    public class AccountService : IAccountService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AccountService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ResponseDTO<List<DisplayAccontDTO>>> GetSelectableAccountsAsync()
        {
            var AllAcounts = await _unitOfWork.AccountRepo.GetAllAsync();

            if (AllAcounts == null || !AllAcounts.Any())
            {
                return new ResponseDTO<List<DisplayAccontDTO>>
                {
                    IsSuccess = false,
                    Message = "No accounts found.",
                    Data = null
                };
            }

            var accountDTOs = _mapper.Map<List<DisplayAccontDTO>>(AllAcounts);
            return new ResponseDTO<List<DisplayAccontDTO>>
            {
                IsSuccess = true,
                Message = "Accounts retrieved successfully.",
                Data = accountDTOs
            };
        }

    }
}
