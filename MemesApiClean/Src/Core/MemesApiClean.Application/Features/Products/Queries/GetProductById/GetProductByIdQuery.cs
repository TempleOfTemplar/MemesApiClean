using MediatR;
using MemesApiClean.Application.Wrappers;
using MemesApiClean.Domain.Products.DTOs;

namespace MemesApiClean.Application.Features.Products.Queries.GetProductById
{
    public class GetProductByIdQuery : IRequest<BaseResult<ProductDto>>
    {
        public long Id { get; set; }
    }
}
