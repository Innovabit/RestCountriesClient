using System.Collections.Generic;

namespace Innovabit.DotNet.Api.RestCountries.Models
{
    public class CountryName : Name
    {
        public IReadOnlyDictionary<string, Name> NativeName { get; set; } = new Dictionary<string, Name>();
    }
}
