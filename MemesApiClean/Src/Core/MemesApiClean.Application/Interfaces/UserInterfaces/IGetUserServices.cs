using MemesApiClean.Application.DTOs.Account.Requests;
using MemesApiClean.Application.DTOs.Account.Responses;
using MemesApiClean.Application.Wrappers;
using System.Threading.Tasks;

namespace MemesApiClean.Application.Interfaces.UserInterfaces
{
    public interface IGetUserServices
    {
        Task<PagedResponse<UserDto>> GetPagedUsers(GetAllUsersRequest model);
    }
}
