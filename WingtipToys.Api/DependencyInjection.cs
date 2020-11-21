using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace WingtipToys.Api
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApi(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddControllers();
            services.AddSwaggerGen();
            return services;
        }
    }
}
