using Innovabit.DotNet.Api.RestCountries.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Innovabit.DotNet.Api.RestCountries.Contracts
{
    public interface IRestCountriesApiClient
    {
        Task<IEnumerable<Country>> GetAllAsync(CancellationToken cancellationToken = default(CancellationToken), string[]? fields = default(string[]));
        Task<IEnumerable<Country>> GetByNameAsync(string name, bool fullText = false, CancellationToken cancellationToken = default(CancellationToken), string[]? fields = default(string[]));
        Task<IEnumerable<Country>> GetByCodeAsync(string code, CancellationToken cancellationToken = default(CancellationToken), string[]? fields = default(string[]));
        Task<IEnumerable<Country>> GetByCodesAsync(IEnumerable<string> codes, CancellationToken cancellationToken = default(CancellationToken), string[]? fields = default(string[]));
        Task<IEnumerable<Country>> GetByCurrencyAsync(string currency, CancellationToken cancellationToken = default(CancellationToken), string[]? fields = default(string[]));
        Task<IEnumerable<Country>> GetByLanguageAsync(string language, CancellationToken cancellationToken = default(CancellationToken), string[]? fields = default(string[]));
        Task<IEnumerable<Country>> GetByTranslationAsync(string translation, CancellationToken cancellationToken = default(CancellationToken), string[]? fields = default(string[]));
        Task<IEnumerable<Country>> GetByCapitalCityAsync(string capitalCity, CancellationToken cancellationToken = default(CancellationToken), string[]? fields = default(string[]));
        Task<IEnumerable<Country>> GetByRegionCityAsync(string region, CancellationToken cancellationToken = default(CancellationToken), string[]? fields = default(string[]));
        Task<IEnumerable<Country>> GetBySubregionAsync(string subregion, CancellationToken cancellationToken = default(CancellationToken), string[]? fields = default(string[]));
        Task<IEnumerable<Country>> GetByDemonymAsync(string demonym, CancellationToken cancellationToken = default(CancellationToken), string[]? fields = default(string[]));
    }
}