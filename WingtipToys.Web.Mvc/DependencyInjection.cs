using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace WingtipToys.Web.Mvc
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddWebMvc(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddControllersWithViews();
            return services;
        }
    }
}
