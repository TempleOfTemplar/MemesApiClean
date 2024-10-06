using MediatR;
using MemesApiClean.Application.Interfaces;
using MemesApiClean.Application.Interfaces.Repositories;
using MemesApiClean.Application.Wrappers;
using MemesApiClean.Domain.Products.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace MemesApiClean.Application.Features.Products.Commands.CreateProduct
{
    public class CreateProductCommandHandler(IProductRepository productRepository, IUnitOfWork unitOfWork) : IRequestHandler<CreateProductCommand, BaseResult<long>>
    {
        public async Task<BaseResult<long>> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = new Product(request.Name, request.Price, request.BarCode);

            await productRepository.AddAsync(product);
            await unitOfWork.SaveChangesAsync();

            return product.Id;
        }
    }
}
