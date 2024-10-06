using MediatR;
using MemesApiClean.Application.Wrappers;

namespace MemesApiClean.Application.Features.Products.Commands.DeleteProduct
{
    public class DeleteProductCommand : IRequest<BaseResult>
    {
        public long Id { get; set; }
    }
}
