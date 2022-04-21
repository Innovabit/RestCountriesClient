using Innovabit.DotNet.Api.RestCountries.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace Innovabit.DotNet.Api.RestCountries.Converters
{
    internal class CountryStatusEnumConverter : StringEnumConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(Status);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            switch (reader.Value)
            {
                case "user-assigned":
                    return Status.UserAssigned;
                case "officially-assigned":
                    return Status.OfficiallyAssigned;
                default:
                    return Status.Undefined;
            }
        }
    }
}
