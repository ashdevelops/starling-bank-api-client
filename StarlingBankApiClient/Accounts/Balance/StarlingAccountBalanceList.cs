using Newtonsoft.Json;

namespace ConsoleApp5;

public class StarlingAccountBalanceList
{
    [JsonProperty("clearedBalance")]
    public StarlingBalance ClearedBalance { get; set; }
    
    [JsonProperty("effectiveBalance")]
    public StarlingBalance EffectiveBalance { get; set; }
    
    [JsonProperty("pendingTransactions")]
    public StarlingBalance PendingTransactions { get; set; }
    
    [JsonProperty("acceptedOverdraft")]
    public StarlingBalance AcceptedOverdraft { get; set; }
    
    [JsonProperty("amount")]
    public StarlingBalance Amount { get; set; }
    
    [JsonProperty("totalClearedBalance")]
    public StarlingBalance TotalClearedBalance { get; set; }
    
    [JsonProperty("totalEffectiveBalance")]
    public StarlingBalance TotalEffectiveBalance { get; set; }
}