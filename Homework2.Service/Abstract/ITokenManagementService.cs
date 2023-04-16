using Homework2.Base;
using Homework2.Dto;
using Homework2.Base.Response;

namespace Homework2.Service.Abstract;

public interface ITokenManagementService
{
    BaseResponse<TokenResponse> GenerateToken(TokenRequest request);
}
