namespace Innovabit.DotNet.Api.RestCountries.Models
{
    public sealed class LatLng
    {
        public double Latitude { get; private set; }
        public double Longitude { get; private set; }

        public LatLng(double lat, double lng)
        {
            Latitude = lat;
            Longitude = lng;
        }
    }
}
