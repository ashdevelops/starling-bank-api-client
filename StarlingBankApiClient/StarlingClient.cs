namespace ConsoleApp5;

public class StarlingClient : BaseClient
{
    public StarlingClient(string accessCode) : base(accessCode)
    {
    }

    public StarlingAccountList GetAccounts()
    {
        return GetJsonForEndpoint<StarlingAccountList>("api/v2/accounts");
    }

    public StarlingAccountBalanceList GetBalances()
    {
        var accountUid = GetAccounts().Accounts.First().Uuid;
        return GetJsonForEndpoint<StarlingAccountBalanceList>($"api/v2/accounts/{accountUid}/balance");
    }

    public StarlingTransactionFeedItemCollection GetFeedItems(DateTime since)
    {
        var account = GetAccounts().Accounts.First();
        var accountUid = account.Uuid;
        var categoryUid = account.DefaultCategory;
        
        Console.WriteLine($"api/v2/feed/account/{accountUid}/category/{categoryUid}?changesSince=" + since.ToString("yyyy-MM-ddTHH:mm:ssZ"));
        
        return GetJsonForEndpoint<StarlingTransactionFeedItemCollection>($"api/v2/feed/account/{accountUid}/category/{categoryUid}?changesSince=" + since.ToString("yyyy-MM-ddTHH:mm:ssZ"));
    }
}