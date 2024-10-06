using MediatR;
using MemesApiClean.Application.Interfaces.Repositories;
using MemesApiClean.Application.Wrappers;
using MemesApiClean.Domain.Products.DTOs;
using System.Threading;
using System.Threading.Tasks;

namespace MemesApiClean.Application.Features.Products.Queries.GetPagedListProduct
{
    public class GetPagedListProductQueryHandler(IProductRepository productRepository) : IRequestHandler<GetPagedListProductQuery, PagedResponse<ProductDto>>
    {
        public async Task<PagedResponse<ProductDto>> Handle(GetPagedListProductQuery request, CancellationToken cancellationToken)
        {
            return await productRepository.GetPagedListAsync(request.PageNumber, request.PageSize, request.Name);
        }
    }
}
