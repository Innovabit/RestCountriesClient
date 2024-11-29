using Flurl;
using Flurl.Http;
using Flurl.Http.Configuration;
using Innovabit.DotNet.Api.RestCountries.Converters;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Innovabit.DotNet.Api.RestCountries.Extensions
{
    internal static class GlobalRequestConfigurationExtension
    {
        internal static IFlurlRequest Prepare(this Url url)
        {
            var request = new FlurlRequest(url);

            request.Settings.JsonSerializer = new DefaultJsonSerializer(new JsonSerializerOptions
            {
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                PropertyNameCaseInsensitive = true,
                Converters = {
                    new CountryStatusEnumConverter(),
                    new LatLngConverter(),
                    new JsonStringEnumConverter()
                }
            });

            return request;
        }
    }
}
