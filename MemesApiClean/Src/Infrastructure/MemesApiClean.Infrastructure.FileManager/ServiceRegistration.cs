using MemesApiClean.Application.Interfaces;
using MemesApiClean.Infrastructure.FileManager.Contexts;
using MemesApiClean.Infrastructure.FileManager.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MemesApiClean.Infrastructure.FileManager
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddFileManagerInfrastructure(this IServiceCollection services, IConfiguration configuration, bool useInMemoryDatabase)
        {
            if (useInMemoryDatabase)
            {
                services.AddDbContext<FileManagerDbContext>(options =>
                    options.UseInMemoryDatabase(nameof(FileManagerDbContext)));
            }
            else
            {
                services.AddDbContext<FileManagerDbContext>(options =>
                    options.UseSqlServer(configuration.GetConnectionString("FileManagerConnection")));
            }

            services.AddScoped<IFileManagerService, FileManagerService>();

            return services;
        }
    }
}
