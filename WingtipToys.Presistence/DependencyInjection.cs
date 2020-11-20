using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WingtipToys.Application.Interfaces;

namespace WingtipToys.Presistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPresistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                                                 options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                                                    x => x.MigrationsAssembly("WingtipToys.Presistence")));

            services.AddScoped<IApplicationDbContext>(provider => provider.GetService<ApplicationDbContext>());
            return services;
        }
    }
}
