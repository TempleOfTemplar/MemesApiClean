using System.Threading.Tasks;

namespace MemesApiClean.Application.Interfaces
{
    public interface IUnitOfWork
    {
        Task<bool> SaveChangesAsync();
    }
}
