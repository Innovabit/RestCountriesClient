using Innovabit.DotNet.Api.RestCountries.Enums;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Innovabit.DotNet.Api.RestCountries.Converters
{
    internal class CountryStatusEnumConverter : JsonConverter<Status>
    {
        public override Status Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.String)
            {
                var value = reader.GetString();
                return value switch
                {
                    "user-assigned" => Status.UserAssigned,
                    "officially-assigned" => Status.OfficiallyAssigned,
                    _ => Status.Undefined
                };
            }

            throw new JsonException($"Unexpected token parsing Status: {reader.TokenType}");
        }

        public override void Write(Utf8JsonWriter writer, Status value, JsonSerializerOptions options)
        {
            var stringValue = value switch
            {
                Status.UserAssigned => "user-assigned",
                Status.OfficiallyAssigned => "officially-assigned",
                _ => null
            };

            if (stringValue == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(stringValue);
            }
        }
    }
}
