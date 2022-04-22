using Innovabit.DotNet.Api.RestCountries.Converters;
using Innovabit.DotNet.Api.RestCountries.Models;
using Newtonsoft.Json;
using System.IO;
using Xunit;

namespace Innovabit.DotNet.Api.RestCountries.Tests.Converters
{
    public class LatLngConverterTests
    {
        private readonly LatLngConverter _converter;

        public LatLngConverterTests()
        {
            _converter = new LatLngConverter();
        }

        [Fact]
        public void CanConvert_LatLng_True()
        {
            var canConvert = _converter.CanConvert(typeof(LatLng));
            Assert.True(canConvert);
        }

        [Fact]
        public void CanConvert_Other_False()
        {
            var canConvert = _converter.CanConvert(typeof(object));
            Assert.False(canConvert);
        }

        [Fact]
        public void ReadJson_DoubleArray_LatLng()
        {
            var json = "{\"coords\":[1.23,4.56]}";
            var jsonReader = new JsonTextReader(new StringReader(json));

            while (jsonReader.TokenType != JsonToken.StartArray)
            {
                jsonReader.Read();
            }

            var result = _converter.ReadJson(jsonReader, typeof(LatLng), null, JsonSerializer.CreateDefault());

            Assert.IsType<LatLng>(result);

            var latLng = (LatLng)result;
            Assert.Equal(1.23, latLng.Latitude);
            Assert.Equal(4.56, latLng.Longitude);
        }

        [Fact]
        public void ReadJson_Null_Null()
        {
            var json = "{\"coords\":null}";
            var jsonReader = new JsonTextReader(new StringReader(json));

            while (jsonReader.TokenType != JsonToken.Null)
            {
                jsonReader.Read();
            }

            var result = _converter.ReadJson(jsonReader, typeof(LatLng), null, JsonSerializer.CreateDefault());

            Assert.Null(result);
        }
    }
}
