using Innovabit.DotNet.Api.RestCountries.Contracts;
using Microsoft.Extensions.DependencyInjection;

namespace Innovabit.DotNet.Api.RestCountries
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddCountriesApi(this IServiceCollection services)
        {
            services.AddScoped<IRestCountriesApiClient, RestCountriesApiClient>();
            return services;
        }
    }
}
