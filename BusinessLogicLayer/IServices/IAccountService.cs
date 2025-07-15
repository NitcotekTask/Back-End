using BusinessLogicLayer.DTOs.AccountDTOs;
using BusinessLogicLayer.DTOs.ResponseDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.IServices
{
    public interface IAccountService
    {

        public Task<ResponseDTO<List<DisplayAccontDTO>>> GetSelectableAccountsAsync();

    }
}
