using Microsoft.Extensions.DependencyInjection;

namespace WebClinica.Application
{
    public static class ApplicationModule
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            return services;
        }
    }
}
