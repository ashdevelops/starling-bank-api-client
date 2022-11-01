using Newtonsoft.Json;

namespace StarlingBankApiClient;

public class StarlingBalance
{
    [JsonProperty("currency")]
    public string Currency { get; set; }
        
    [JsonProperty("minorUnits")]
    public int MinorUnits { get; set; }

}