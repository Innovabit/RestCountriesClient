using Innovabit.DotNet.Api.RestCountries.Models;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Innovabit.DotNet.Api.RestCountries.Converters
{
    internal class LatLngConverter : JsonConverter<LatLng?>
    {
        public override LatLng? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
            {
                return null;
            }

            if (reader.TokenType == JsonTokenType.StartArray)
            {
                var values = JsonSerializer.Deserialize<double[]>(ref reader, options);
                if (values != null && values.Length == 2)
                {
                    return new LatLng(values[0], values[1]);
                }
            }

            throw new JsonException("Formato inválido para LatLng.");
        }

        public override void Write(Utf8JsonWriter writer, LatLng? value, JsonSerializerOptions options)
        {
            if (value is null)
            {
                writer.WriteNullValue();
                return;
            }

            writer.WriteStartArray();
            writer.WriteNumberValue(value.Latitude);
            writer.WriteNumberValue(value.Longitude);
            writer.WriteEndArray();
        }
    }
}