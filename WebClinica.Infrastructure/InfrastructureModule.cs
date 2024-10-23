using Microsoft.Extensions.DependencyInjection;
using WebClinica.Infrastructure.Factory;

namespace WebClinica.Infrastructure
{
    public static class InfrastructureModule
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddSqlFactory();

            return services;
        }

        public static IServiceCollection AddSqlFactory(this IServiceCollection services)
        {
            services.AddScoped<SqlFactory>();

            return services;
        }
    }
}
