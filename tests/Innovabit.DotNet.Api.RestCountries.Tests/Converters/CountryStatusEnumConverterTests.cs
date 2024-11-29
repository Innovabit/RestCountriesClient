using Innovabit.DotNet.Api.RestCountries.Converters;
using Innovabit.DotNet.Api.RestCountries.Enums;
using System.Text.Json;
using Xunit;

namespace Innovabit.DotNet.Api.RestCountries.Tests.Converters
{
    public class CountryStatusEnumConverterTests
    {
        private readonly JsonSerializerOptions _options;

        public CountryStatusEnumConverterTests()
        {
            _options = new JsonSerializerOptions
            {
                Converters = { new CountryStatusEnumConverter() }
            };
        }

        [Fact]
        public void ReadJson_ValidTokenUserAssigned_UserAssigned()
        {
            var json = "{ \"status\": \"user-assigned\" }";

            var document = JsonDocument.Parse(json);
            var reader = document.RootElement.GetProperty("status").GetRawText();

            var result = JsonSerializer.Deserialize<Status>(reader, _options);

            Assert.Equal(Status.UserAssigned, result);
        }

        [Fact]
        public void ReadJson_ValidTokenOfficiallyAssigned_OfficiallyAssigned()
        {
            var json = "{ \"status\": \"officially-assigned\" }";

            var document = JsonDocument.Parse(json);
            var reader = document.RootElement.GetProperty("status").GetRawText();

            var result = JsonSerializer.Deserialize<Status>(reader, _options);

            Assert.Equal(Status.OfficiallyAssigned, result);
        }

        [Fact]
        public void ReadJson_InvalidToken_Undefined()
        {
            var json = "{ \"status\": \"anything\" }";

            var document = JsonDocument.Parse(json);
            var reader = document.RootElement.GetProperty("status").GetRawText();

            var result = JsonSerializer.Deserialize<Status>(reader, _options);

            Assert.Equal(Status.Undefined, result);
        }

        [Fact]
        public void WriteJson_ValidStatus_UserAssigned()
        {
            var status = Status.UserAssigned;

            var json = JsonSerializer.Serialize(status, _options);

            Assert.Equal("\"user-assigned\"", json);
        }

        [Fact]
        public void WriteJson_ValidStatus_OfficiallyAssigned()
        {
            var status = Status.OfficiallyAssigned;

            var json = JsonSerializer.Serialize(status, _options);

            Assert.Equal("\"officially-assigned\"", json);
        }

        [Fact]
        public void WriteJson_InvalidStatus_Null()
        {
            var status = Status.Undefined;

            var json = JsonSerializer.Serialize(status, _options);

            Assert.Equal("null", json);
        }
    }
}
