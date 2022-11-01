using Newtonsoft.Json;
using RestSharp;

namespace StarlingBankApiClient;

public class BaseClient
{
    private readonly RestClient _client;

    protected BaseClient(string accessCode)
    {
        _client = new RestClient("https://api.starlingbank.com");
        _client.AddDefaultHeader("Authorization", $"Bearer {accessCode}");
    }

    public T GetJsonForEndpoint<T>(string endpoint)
    {
        var request = new RestRequest(endpoint);
        var queryResult = _client.Get(request);
        var data = JsonConvert.DeserializeObject<T>(queryResult.Content);

        return data;
    }
}