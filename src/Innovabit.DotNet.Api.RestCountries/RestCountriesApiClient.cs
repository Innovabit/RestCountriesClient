using Innovabit.DotNet.Api.RestCountries.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;
using Innovabit.DotNet.Api.RestCountries.Extensions;
using Innovabit.DotNet.Api.RestCountries.Contracts;

namespace Innovabit.DotNet.Api.RestCountries
{
    internal class RestCountriesApiClient : IRestCountriesApiClient
    {
        private const string BaseAddress = "https://restcountries.com/v3.1";

        public async Task<IEnumerable<Country>> GetAllAsync(CancellationToken cancellationToken = default, string[]? fields = null)
        {
            var url = BaseAddress.AppendPathSegment("all");

            url = HandleFields(url, fields);

            return await url.Prepare().GetJsonAsync<IEnumerable<Country>>(cancellationToken);
        }

        public async Task<IEnumerable<Country>> GetByCapitalCityAsync(string capitalCity, CancellationToken cancellationToken = default, string[]? fields = null)
        {
            var url = BaseAddress.AppendPathSegment("capital")
                .AppendPathSegment(capitalCity);

            url = HandleFields(url, fields);

            return await url.Prepare().GetJsonAsync<IEnumerable<Country>>(cancellationToken);
        }

        public async Task<IEnumerable<Country>> GetByCodeAsync(string code, CancellationToken cancellationToken = default, string[]? fields = null)
        {
            var url = BaseAddress.AppendPathSegment("alpha")
                .AppendPathSegment(code);

            url = HandleFields(url, fields);

            return await url.Prepare().GetJsonAsync<IEnumerable<Country>>(cancellationToken);
        }

        public async Task<IEnumerable<Country>> GetByCodesAsync(IEnumerable<string> codes, CancellationToken cancellationToken = default, string[]? fields = null)
        {
            var url = BaseAddress.AppendPathSegment("alpha")
                .SetQueryParam("codes", string.Join(',', codes));

            url = HandleFields(url, fields);

            return await url.Prepare().GetJsonAsync<IEnumerable<Country>>(cancellationToken);
        }

        public async Task<IEnumerable<Country>> GetByCurrencyAsync(string currency, CancellationToken cancellationToken = default, string[]? fields = null)
        {
            var url = BaseAddress.AppendPathSegment("currency")
                .AppendPathSegment(currency);

            url = HandleFields(url, fields);

            return await url.Prepare().GetJsonAsync<IEnumerable<Country>>(cancellationToken);
        }

        public async Task<IEnumerable<Country>> GetByDemonymAsync(string demonym, CancellationToken cancellationToken = default, string[]? fields = null)
        {
            var url = BaseAddress.AppendPathSegment("demonym")
                .AppendPathSegment(demonym);

            url = HandleFields(url, fields);

            return await url.Prepare().GetJsonAsync<IEnumerable<Country>>(cancellationToken);
        }

        public async Task<IEnumerable<Country>> GetByLanguageAsync(string language, CancellationToken cancellationToken = default, string[]? fields = null)
        {
            var url = BaseAddress.AppendPathSegment("lang")
                .AppendPathSegment(language);

            url = HandleFields(url, fields);

            return await url.Prepare().GetJsonAsync<IEnumerable<Country>>(cancellationToken);
        }

        public async Task<IEnumerable<Country>> GetByNameAsync(string name, bool fullText = false, CancellationToken cancellationToken = default, string[]? fields = null)
        {
            var url = BaseAddress.AppendPathSegment("name")
                .AppendPathSegment(name);

            if (fullText)
                url = url.SetQueryParam("fullText", true);

            url = HandleFields(url, fields);

            return await url.Prepare().GetJsonAsync<IEnumerable<Country>>(cancellationToken);
        }

        public async Task<IEnumerable<Country>> GetByRegionCityAsync(string region, CancellationToken cancellationToken = default, string[]? fields = null)
        {
            var url = BaseAddress.AppendPathSegment("region")
                .AppendPathSegment(region);

            url = HandleFields(url, fields);

            return await url.Prepare().GetJsonAsync<IEnumerable<Country>>(cancellationToken);
        }

        public async Task<IEnumerable<Country>> GetBySubregionAsync(string subregion, CancellationToken cancellationToken = default, string[]? fields = null)
        {
            var url = BaseAddress.AppendPathSegment("subregion")
                .AppendPathSegment(subregion);

            url = HandleFields(url, fields);

            return await url.Prepare().GetJsonAsync<IEnumerable<Country>>(cancellationToken);
        }

        public async Task<IEnumerable<Country>> GetByTranslationAsync(string translation, CancellationToken cancellationToken = default, string[]? fields = null)
        {
            var url = BaseAddress.AppendPathSegment("translation")
                .AppendPathSegment(translation);

            url = HandleFields(url, fields);

            return await url.Prepare().GetJsonAsync<IEnumerable<Country>>(cancellationToken);
        }

        private static Url HandleFields(Url inputUrl, string[]? fields = null)
        {
            if (fields == null)
                return inputUrl;

            var fieldsQueryValue = string.Join(',', fields);
            return inputUrl.SetQueryParam("fields", fieldsQueryValue);
        }
    }
}
