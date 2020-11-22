using FluentValidation.AspNetCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WingtipToys.Api.Validation;

namespace WingtipToys.Api
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApi(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddControllers(options => { options.Filters.Add(new ApiValidationFilter()); })
                .AddFluentValidation(mvcConfiguration => mvcConfiguration.RegisterValidatorsFromAssemblyContaining<Startup>());
            services.AddSwaggerGen();
            return services;
        }
    }
}
