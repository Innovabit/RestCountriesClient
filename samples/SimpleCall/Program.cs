using Innovabit.DotNet.Api.RestCountries;
using Innovabit.DotNet.Api.RestCountries.Contracts;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();
services.AddCountriesApi();

var provider = services.BuildServiceProvider();

var apiClient = provider.GetRequiredService<IRestCountriesApiClient>();

var countries = await apiClient.GetAllAsync();

var regions = string.Join(',', countries.GroupBy(x => x.Subregion).Select(x => x.Key).OrderBy(x => x).ToArray());

Console.ReadLine();