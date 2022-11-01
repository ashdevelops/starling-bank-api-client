using StarlingBankApiClient.Accounts;
using StarlingBankApiClient.Accounts.Balance;

namespace StarlingBankApiClient;

public class StarlingClient : BaseClient
{
    public StarlingClient(string accessCode) : base(accessCode)
    {
    }

    public StarlingAccountList GetAccounts()
    {
        return GetJsonForEndpoint<StarlingAccountList>("accounts");
    }

    public StarlingAccountBalanceList GetBalances()
    {
        var accountUid = GetAccounts().Accounts.First().Uuid;
        return GetJsonForEndpoint<StarlingAccountBalanceList>($"accounts/{accountUid}/balance");
    }

    public StarlingTransactionFeedItemCollection GetFeedItems(DateTime since)
    {
        var account = GetAccounts().Accounts.First();
        var accountUid = account.Uuid;
        var categoryUid = account.DefaultCategory;
        
        Console.WriteLine($"feed/account/{accountUid}/category/{categoryUid}?changesSince=" + since.ToString("yyyy-MM-ddTHH:mm:ssZ"));
        
        return GetJsonForEndpoint<StarlingTransactionFeedItemCollection>($"feed/account/{accountUid}/category/{categoryUid}?changesSince=" + since.ToString("yyyy-MM-ddTHH:mm:ssZ"));
    }
}