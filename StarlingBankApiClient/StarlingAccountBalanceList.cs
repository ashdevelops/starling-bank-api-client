using Newtonsoft.Json;

namespace StarlingBankApiClient;

public class StarlingTransactionFeedItemCollection
{
    [JsonProperty("feedItems")]
    public List<StarlingTransactionFeedItem> FeedItems { get; set; }
}