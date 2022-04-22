using Innovabit.DotNet.Api.RestCountries.Enums;
using System.Collections.Generic;

namespace Innovabit.DotNet.Api.RestCountries.Models
{

    public class Country
    {
        public CountryName Name { get; set; } = new CountryName();
        public IEnumerable<string> Tld { get; set; } = new List<string> { };
        public string Cca2 { get; set; } = string.Empty;
        public string Ccn3 { get; set; } = string.Empty;
        public string Cca3 { get; set; } = string.Empty;
        public string Cioc { get; set; } = string.Empty;
        public bool Independent { get; set; } = true;
        public Status Status { get; set; }
        public bool UnMember { get; set; } = true;
        public IReadOnlyDictionary<string, Currency> Currencies { get; set; } = new Dictionary<string, Currency>();
        public Idd Idd { get; set; } = new Idd();
        public IEnumerable<string> Capital { get; set; } = new List<string>();
        public IEnumerable<string> AltSpellings { get; set; } = new List<string>();
        public string Region { get; set; } = string.Empty;
        public string Subregion { get; set; } = string.Empty;
        public IReadOnlyDictionary<string, string> Languages { get; set; } = new Dictionary<string, string>();
        public IReadOnlyDictionary<string, Name> Translations { get; set; } = new Dictionary<string, Name>();
        public LatLng? Latlng { get; set; }
        public bool Landlocked { get; set; } = false;
        public IEnumerable<string> Borders { get; set; } = new List<string>();
        public double Area { get; set; }
        public IReadOnlyDictionary<string, Demonym> Demonyms { get; set; } = new Dictionary<string, Demonym>();
        public string Flag { get; set; } = string.Empty;
        public Maps Maps { get; set; } = new Maps();
        public int Population { get; set; }
        public IReadOnlyDictionary<string, double> Gini { get; set; } = new Dictionary<string, double>();
        public string Fifa { get; set; } = string.Empty;
        public Car Car { get; set; } = new Car();
        public IEnumerable<string> Timezones { get; set; } = new List<string>();
        public IEnumerable<string> Continents { get; set; } = new List<string>();
        public StateSymbol? Flags { get; set; }
        public StateSymbol? CoatOfArms { get; set; }
        public string StartOfWeek { get; set; } = string.Empty;
        public CapitalInfo CapitalInfo { get; set; } = new CapitalInfo();
        public PostalCode PostalCode { get; set; } = new PostalCode();
    }
}
