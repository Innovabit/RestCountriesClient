using Innovabit.DotNet.Api.RestCountries.Converters;
using Innovabit.DotNet.Api.RestCountries.Enums;
using Newtonsoft.Json;
using System.IO;
using Xunit;

namespace Innovabit.DotNet.Api.RestCountries.Tests.Converters
{
    public class CountryStatusEnumConverterTests
    {
        private readonly CountryStatusEnumConverter _converter;

        public CountryStatusEnumConverterTests()
        {
            _converter = new CountryStatusEnumConverter();
        }

        [Fact]
        public void CanConvert_StatusType_True()
        {
            var theType = typeof(Status);

            var canConvert = _converter.CanConvert(theType);

            Assert.True(canConvert);
        }

        [Fact]
        public void CanConvert_ObjectType_False()
        {
            var theType = typeof(object);

            var canConvert = _converter.CanConvert(theType);

            Assert.False(canConvert);
        }

        [Fact]
        public void ReadJson_ValidTokenUserAssigned_UserAssigned()
        {
            var tokenValue = "{ \"status\":\"user-assigned\" }";

            var jsonReader = new JsonTextReader(new StringReader(tokenValue));

            while (jsonReader.TokenType != JsonToken.String)
            {
                jsonReader.Read();
            }

            var result = _converter.ReadJson(jsonReader, typeof(Status), tokenValue, JsonSerializer.CreateDefault());

            Assert.Equal(Status.UserAssigned, result);
        }

        [Fact]
        public void ReadJson_ValidTokenOfficiallyAssigned_OfficiallyAssigned()
        {
            var tokenValue = "{ \"status\":\"officially-assigned\" }";

            var jsonReader = new JsonTextReader(new StringReader(tokenValue));

            while (jsonReader.TokenType != JsonToken.String)
            {
                jsonReader.Read();
            }

            var result = _converter.ReadJson(jsonReader, typeof(Status), tokenValue, JsonSerializer.CreateDefault());

            Assert.Equal(Status.OfficiallyAssigned, result);
        }

        [Fact]
        public void ReadJson_ValidTokenAnything_Undefined()
        {
            var tokenValue = "{ \"status\":\"anything\" }";

            var jsonReader = new JsonTextReader(new StringReader(tokenValue));

            while (jsonReader.TokenType != JsonToken.String)
            {
                jsonReader.Read();
            }

            var result = _converter.ReadJson(jsonReader, typeof(Status), tokenValue, JsonSerializer.CreateDefault());

            Assert.Equal(Status.Undefined, result);
        }
    }
}
