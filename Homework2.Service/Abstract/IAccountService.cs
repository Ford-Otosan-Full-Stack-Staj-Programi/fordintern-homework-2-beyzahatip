using Homework2.Base.Response;
using Homework2.Data;
using Homework2.Dto.Dto;
using Homework2.Service.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2.Service.Abstract
{
    public interface IAccountService : IBaseService<AccountDto, Account>
    {
        BaseResponse<AccountDto> GetByUsername(string username);
    }
}
