using AutoMapper;
using Homework2.Base.Response;
using Homework2.Data;
using Homework2.Dto.Dto;
using Homework2.Service.Abstract;
using Homework2.Service.Base.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2.Service.Concrete
{
    public class AccountService : BaseService<AccountDto, Account>, IAccountService
    {
        private readonly IGenericRepository<Account> genericRepository;
        private readonly IMapper mapper;
        public AccountService(IUnitOfWork unitOfWork, IMapper mapper, IGenericRepository<Account> genericRepository) : base(unitOfWork, mapper, genericRepository)
        {
            this.genericRepository = genericRepository;
            this.mapper = mapper;
        }

        public BaseResponse<AccountDto> GetByUsername(string username)
        {
            var account = genericRepository.Where(x => x.Username == username).FirstOrDefault();
            var mapped = mapper.Map<Account, AccountDto>(account);
            return new BaseResponse<AccountDto>(mapped);
        }
    }
}
