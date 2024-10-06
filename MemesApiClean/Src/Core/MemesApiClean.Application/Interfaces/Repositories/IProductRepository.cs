using MemesApiClean.Application.DTOs;
using MemesApiClean.Domain.Products.DTOs;
using MemesApiClean.Domain.Products.Entities;
using System.Threading.Tasks;

namespace MemesApiClean.Application.Interfaces.Repositories
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        Task<PaginationResponseDto<ProductDto>> GetPagedListAsync(int pageNumber, int pageSize, string name);
    }
}
