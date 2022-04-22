using Flurl;
using Flurl.Http;
using Flurl.Http.Configuration;
using Innovabit.DotNet.Api.RestCountries.Converters;
using Newtonsoft.Json;
using System.Collections.Generic;
using NullValueHandling = Newtonsoft.Json.NullValueHandling;

namespace Innovabit.DotNet.Api.RestCountries.Extensions
{
    internal static class GlobalRequestConfigurationExtension
    {
        internal static IFlurlRequest Prepare(this Url url)
        {
            var jsonSerializerSettings = new JsonSerializerSettings()
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                Converters = new List<JsonConverter>
                {
                    new CountryStatusEnumConverter(),
                    new LatLngConverter()
                }
            };

            return new FlurlRequest(url).ConfigureRequest(settings =>
            {
                settings.JsonSerializer = new NewtonsoftJsonSerializer(jsonSerializerSettings);
            });
        }
    }
}
