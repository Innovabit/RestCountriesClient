using Innovabit.DotNet.Api.RestCountries.Contracts;
using Microsoft.Extensions.DependencyInjection;

namespace Innovabit.DotNet.Api.RestCountries
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddCountriesApi(this IServiceCollection services,
            ServiceLifetime lifeTime = ServiceLifetime.Scoped)
        {
            var serviceDescriptor =
                new ServiceDescriptor(typeof(IRestCountriesApiClient), typeof(RestCountriesApiClient), lifeTime);
            services.Add(serviceDescriptor);
            return services;
        }
    }
}
