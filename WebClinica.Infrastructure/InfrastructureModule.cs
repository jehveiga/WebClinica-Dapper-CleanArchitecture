using Microsoft.Extensions.DependencyInjection;
using WebClinica.Domain.Interfaces.Repositories;
using WebClinica.Infrastructure.Factory;
using WebClinica.Infrastructure.Repositories;

namespace WebClinica.Infrastructure
{
    public static class InfrastructureModule
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddSqlFactory()
                    .AddRepository();

            return services;
        }

        public static IServiceCollection AddSqlFactory(this IServiceCollection services)
        {
            services.AddScoped<SqlFactory>();

            return services;
        }

        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            services.AddTransient<IMedicoRepository, MedicoRepository>();

            return services;
        }
    }
}
