using Innovabit.DotNet.Api.RestCountries.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Linq;

namespace Innovabit.DotNet.Api.RestCountries.Converters
{
    internal class LatLngConverter : JsonConverter<LatLng?>
    {
        public override LatLng? ReadJson(JsonReader reader, Type objectType, LatLng? existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var token = JObject.ReadFrom(reader);

            var values = token.Values<double>().ToArray();

            return new LatLng(values[0], values[1]);
        }

        public override void WriteJson(JsonWriter writer, LatLng? value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
