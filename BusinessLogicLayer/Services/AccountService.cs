using AutoMapper;
using DataAccessLayer.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class AccountService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
    }
}
