using MemesApiClean.Application.DTOs;
using MemesApiClean.Application.Interfaces.Repositories;
using MemesApiClean.Domain.Products.DTOs;
using MemesApiClean.Domain.Products.Entities;
using MemesApiClean.Infrastructure.Persistence.Contexts;
using System.Linq;
using System.Threading.Tasks;

namespace MemesApiClean.Infrastructure.Persistence.Repositories
{
    public class ProductRepository(ApplicationDbContext dbContext) : GenericRepository<Product>(dbContext), IProductRepository
    {
        public async Task<PaginationResponseDto<ProductDto>> GetPagedListAsync(int pageNumber, int pageSize, string name)
        {
            var query = dbContext.Products.OrderBy(p => p.Created).AsQueryable();

            if (!string.IsNullOrEmpty(name))
            {
                query = query.Where(p => p.Name.Contains(name));
            }

            return await Paged(
                query.Select(p => new ProductDto(p)),
                pageNumber,
                pageSize);

        }
    }
}
