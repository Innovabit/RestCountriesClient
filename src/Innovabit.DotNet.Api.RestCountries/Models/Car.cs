using Innovabit.DotNet.Api.RestCountries.Enums;
using System.Collections.Generic;

namespace Innovabit.DotNet.Api.RestCountries.Models
{
    public class Car
    {
        public IEnumerable<string> Signs { get; set; } = new List<string>();
        public CarSide Side { get; set; }
    }
}
