using Newtonsoft.Json;

namespace StarlingBankApiClient;

public class StarlingTransactionFeedItem
{
    [JsonProperty("feedItemUid")]
    public string FeedItemUid { get; set; }
    
    [JsonProperty("categoryUid")]
    public string CategoryUid { get; set; }
    
    [JsonProperty("amount")]
    public StarlingBalance Amount { get; set; }
    
    [JsonProperty("sourceAmount")]
    public StarlingBalance SourceAmount { get; set; }
    
    [JsonProperty("direction")]
    public string Direction { get; set; } // TODO: enum?
    
    [JsonProperty("updatedAt")]
    public DateTime UpdatedAt { get; set; }
    
    [JsonProperty("transactionTime")]
    public DateTime TransactionTime { get; set; }
    
    [JsonProperty("settlementTime")]
    public DateTime SettlementTime { get; set; }
    
    [JsonProperty("source")]
    public string Source { get; set; } // TODO: enum?
    
    [JsonProperty("status")]
    public string Status { get; set; } // TODO: enum?
    
    [JsonProperty("transactingApplicationUserUid")]
    public string TransactingApplicationUserUid { get; set; } // TODO: enum?
    
    [JsonProperty("counterPartyType")]
    public string CounterPartyType { get; set; } // TODO: enum?
    
    [JsonProperty("counterPartyUid")]
    public string CounterPartyUid { get; set; }
    
    [JsonProperty("counterPartyName")]
    public string CounterPartyName { get; set; }
    
    [JsonProperty("counterPartySubEntityUid")]
    public string CounterPartySubEntityUid { get; set; }
    
    [JsonProperty("counterPartySubEntityName")]
    public string CounterPartySubEntityName { get; set; }
    
    [JsonProperty("counterPartySubEntityIdentifier")]
    public string CounterPartySubEntityIdentifier { get; set; }
    
    [JsonProperty("counterPartySubEntitySubIdentifier")]
    public string CounterPartySubEntitySubIdentifier { get; set; }
    
    [JsonProperty("reference")]
    public string Reference { get; set; }
    
    [JsonProperty("country")]
    public string Country { get; set; }
    
    [JsonProperty("spendingCategory")]
    public string SpendingCategory { get; set; }
    
    [JsonProperty("hasAttachment")]
    public bool HasAttachment { get; set; }
    
    [JsonProperty("hasReceipt")]
    public bool HasReceipt { get; set; }
}