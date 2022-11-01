using Newtonsoft.Json;

namespace ConsoleApp5;

public class StarlingAccountList
{
    public StarlingAccountList()
    {
        Accounts = new List<StarlingAccount>();
    }
    
    [JsonProperty("accounts")]
    public List<StarlingAccount> Accounts { get; }
}