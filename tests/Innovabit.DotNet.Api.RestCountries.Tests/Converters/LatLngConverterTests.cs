using Innovabit.DotNet.Api.RestCountries.Converters;
using Innovabit.DotNet.Api.RestCountries.Models;
using System.Text.Json;
using Xunit;

namespace Innovabit.DotNet.Api.RestCountries.Tests.Converters
{
    public class LatLngConverterTests
    {
        private readonly JsonSerializerOptions _options;

        public LatLngConverterTests()
        {
            _options = new JsonSerializerOptions
            {
                Converters = { new LatLngConverter() }
            };
        }

        [Fact]
        public void ReadJson_DoubleArray_LatLng()
        {
            var json = "{\"coords\":[1.23,4.56]}";

            // Deserializar el JSON
            var document = JsonDocument.Parse(json);
            var array = document.RootElement.GetProperty("coords");

            var reader = new Utf8JsonReader(array.GetRawText().ToUtf8Bytes());
            var converter = new LatLngConverter();

            reader.Read(); // Avanzar al array
            var result = converter.Read(ref reader, typeof(LatLng), _options);

            Assert.IsType<LatLng>(result);

            var latLng = (LatLng)result;
            Assert.Equal(1.23, latLng.Latitude);
            Assert.Equal(4.56, latLng.Longitude);
        }

        [Fact]
        public void ReadJson_Null_Null()
        {
            var json = "{\"coords\":null}";

            // Deserializar el JSON
            var document = JsonDocument.Parse(json);
            var property = document.RootElement.GetProperty("coords");

            var reader = new Utf8JsonReader(property.GetRawText().ToUtf8Bytes());
            var converter = new LatLngConverter();

            reader.Read(); // Avanzar al valor null
            var result = converter.Read(ref reader, typeof(LatLng), _options);

            Assert.Null(result);
        }
    }

    public static class JsonExtensions
    {
        public static byte[] ToUtf8Bytes(this string json) => System.Text.Encoding.UTF8.GetBytes(json);
    }
}
