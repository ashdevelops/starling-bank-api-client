# StarlingBankApiClient
[![NuGet](https://img.shields.io/nuget/v/StarlingBankApiClient.svg)](https://www.nuget.org/packages/StarlingBankApiClient)

## Getting Started

StarlingBankApiClient is a Starling Bank API client library for .NET and is [available on NuGet](https://www.nuget.org/packages/StarlingBankApiClient/):

```
dotnet add package StarlingBankApiClient
```

## Usage examples

Get an accounts transactions for the last 30 days

```c#
var client = new StarlingClient("personal access token");
var items = client.GetFeedItems(DateTime.Now.Subtract(TimeSpan.FromDays(30)));
```
