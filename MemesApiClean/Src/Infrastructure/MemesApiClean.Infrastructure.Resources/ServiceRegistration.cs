using MemesApiClean.Application.Interfaces;
using MemesApiClean.Infrastructure.Resources.Services;
using Microsoft.Extensions.DependencyInjection;

namespace MemesApiClean.Infrastructure.Resources
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddResourcesInfrastructure(this IServiceCollection services)
        {
            services.AddSingleton<ITranslator, Translator>();

            return services;
        }
    }
}
