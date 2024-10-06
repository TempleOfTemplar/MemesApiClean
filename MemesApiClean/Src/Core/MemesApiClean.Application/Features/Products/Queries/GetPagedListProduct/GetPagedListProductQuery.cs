using MediatR;
using MemesApiClean.Application.Parameters;
using MemesApiClean.Application.Wrappers;
using MemesApiClean.Domain.Products.DTOs;

namespace MemesApiClean.Application.Features.Products.Queries.GetPagedListProduct
{
    public class GetPagedListProductQuery : PaginationRequestParameter, IRequest<PagedResponse<ProductDto>>
    {
        public string Name { get; set; }
    }
}
