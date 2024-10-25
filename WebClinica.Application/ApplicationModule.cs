using Microsoft.Extensions.DependencyInjection;
using WebClinica.Application.Business;

namespace WebClinica.Application
{
    public static class ApplicationModule
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddBusiness();

            return services;
        }

        public static IServiceCollection AddBusiness(this IServiceCollection services)
        {
            services.AddTransient<IMedicoBusiness, MedicoBusiness>();

            return services;
        }
    }
}
