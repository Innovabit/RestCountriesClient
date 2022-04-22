# API Reference

The endpoints available in the API v3.1 corresponds with the following methods:

|Endpoint|Url|Method|
|--|--|--|
|All|<https://restcountries.com/v3.1/all>| `All(GetAllAsync(CancellationToken cancellationToken = default(CancellationToken), string[]? fields = default(string[])))`|
|Name|<https://restcountries.com/v3.1/name/{name}>| `GetByNameAsync(string name, bool fullText = false, CancellationToken cancellationToken = default(CancellationToken), string[]? fields = default(string[]))`|
|Full name|<https://restcountries.com/v3.1/name/{name}?fullText=true>| `GetByNameAsync(string name, bool fullText = true, CancellationToken cancellationToken = default(CancellationToken), string[]? fields = default(string[]))`|
|Code|<https://restcountries.com/v3.1/alpha/{code}>| `GetByCodeAsync(string code, CancellationToken cancellationToken = default(CancellationToken), string[]? fields = default(string[]))`|
|List of codes|<https://restcountries.com/v3.1/alpha?codes={code},{code},{code}>| `GetByCodesAsync(IEnumerable<string> codes, CancellationToken cancellationToken = default(CancellationToken), string[]? fields = default(string[]))`|
|Currency|<https://restcountries.com/v3.1/currency/{currency}>| `GetByCurrencyAsync(string currency, CancellationToken cancellationToken = default(CancellationToken), string[]? fields = default(string[]))`|
|Language|<https://restcountries.com/v3.1/lang/{lang}>| `GetByLanguageAsync(string lang, CancellationToken cancellationToken = default(CancellationToken), string[]? fields = default(string[]))`|
|Translation|<https://restcountries.com/v3.1/translation/{translation}>| `GetByTranslationAsync(string translation, CancellationToken cancellationToken = default(CancellationToken), string[]? fields = default(string[]))`|
|Capital city|<https://restcountries.com/v3.1/capital/{capital}>| `GetByCapitalCityAsync(string capital, CancellationToken cancellationToken = default(CancellationToken), string[]? fields = default(string[]))`|
|Region|<https://restcountries.com/v3.1/region/{region}>| `GetByRegionCityAsync(string region, CancellationToken cancellationToken = default(CancellationToken), string[]? fields = default(string[]))`|
|Subregion|<https://restcountries.com/v3.1/subregion/{region}>| `GetBySubregionAsync(string region, CancellationToken cancellationToken = default(CancellationToken), string[]? fields = default(string[]))`|
|Demonym|<https://restcountries.com/v3.1/demonym/{demonym}>| `GetByDemonymAsync(string demonym, CancellationToken cancellationToken = default(CancellationToken), string[]? fields = default(string[]))`|

>For more information about the endpoints please review [RestCountries](https://restcountries.com/) page
