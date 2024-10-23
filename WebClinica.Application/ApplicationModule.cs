using Microsoft.Extensions.DependencyInjection;
using WebClinica.Domain.Interfaces.Repositories;
using WebClinica.Infrastructure.Repositories;

namespace WebClinica.Application
{
    public static class ApplicationModule
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddRepositories();

            return services;
        }

        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IMedicoRepository, MedicoRepository>();

            return services;
        }
    }
}
