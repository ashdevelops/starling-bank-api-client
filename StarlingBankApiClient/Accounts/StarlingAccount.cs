using Newtonsoft.Json;

namespace StarlingBankApiClient.Accounts;

public class StarlingAccount
{
    [JsonProperty("accountUid")]
    public string Uuid { get; set; }
    
    [JsonProperty("accountType")]
    public StarlingAccountType Type { get; set; }
    
    [JsonProperty("defaultCategory")]
    public string DefaultCategory { get; set; }
    
    [JsonProperty("createdAt")]
    public DateTime Created { get; set; }
    
    [JsonProperty("name")]
    public string Name { get; set; }
}