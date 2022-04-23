# Getting Started

For start using this library please follow these steps:

## 1. Install the library

Open the terminal and under your project directory, run the command

```bash
dotnet add package Innovabit.DotNet.Api.RestCountries
```

## 2. Import namespace

```csharp
using Innovabit.DotNet.Api.RestCountries;
```

## 3. Register dependencies

On your service collection, add the depndencies for the RestCountry api client.

```csharp
services.AddCountriesApi();
```

## 4. Add the dependency

```csharp
namespace MyServiceNamespace;

public class CustomService : ICustomService
{
    private readonly IRestCountriesApiClient _countriesApiClient;

    public CustomService(IRestCountriesApiClient restCountriesApiClient)
    {
        _countriesApiClient = restCountriesApiClient;
    }
}
```