using Newtonsoft.Json;

namespace ConsoleApp5;

public class StarlingBalance
{
    [JsonProperty("currency")]
    public string Currency { get; set; }
        
    [JsonProperty("minorUnits")]
    public int MinorUnits { get; set; }

}