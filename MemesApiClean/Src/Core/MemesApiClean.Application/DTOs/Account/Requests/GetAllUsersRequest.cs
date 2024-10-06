using MemesApiClean.Application.Parameters;

namespace MemesApiClean.Application.DTOs.Account.Requests
{
    public class GetAllUsersRequest : PaginationRequestParameter
    {
        public string Name { get; set; }
    }
}
