using MemesApiClean.Application.DTOs.Account.Requests;
using MemesApiClean.Application.DTOs.Account.Responses;
using MemesApiClean.Application.Wrappers;
using System.Threading.Tasks;

namespace MemesApiClean.Application.Interfaces.UserInterfaces
{
    public interface IAccountServices
    {
        Task<BaseResult<string>> RegisterGhostAccount();
        Task<BaseResult> ChangePassword(ChangePasswordRequest model);
        Task<BaseResult> ChangeUserName(ChangeUserNameRequest model);
        Task<BaseResult<AuthenticationResponse>> Authenticate(AuthenticationRequest request);
        Task<BaseResult<AuthenticationResponse>> AuthenticateByUserName(string username);

    }
}
