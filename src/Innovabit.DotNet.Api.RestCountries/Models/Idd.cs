using System.Collections.Generic;

namespace Innovabit.DotNet.Api.RestCountries.Models
{
    public class Idd
    {
        public string Root { get; set; } = string.Empty;
        public IEnumerable<string> Suffixes { get; set; } = new List<string>();
    }
}
