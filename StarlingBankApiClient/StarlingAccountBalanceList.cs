using Newtonsoft.Json;

namespace ConsoleApp5;

public class StarlingTransactionFeedItemCollection
{
    [JsonProperty("feedItems")]
    public List<StarlingTransactionFeedItem> FeedItems { get; set; }
}