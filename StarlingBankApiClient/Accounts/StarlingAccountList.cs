using Newtonsoft.Json;

namespace StarlingBankApiClient.Accounts;

public class StarlingAccountList
{
    public StarlingAccountList()
    {
        Accounts = new List<StarlingAccount>();
    }
    
    [JsonProperty("accounts")]
    public List<StarlingAccount> Accounts { get; }
}