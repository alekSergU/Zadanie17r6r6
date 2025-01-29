namespace Zadanie17r6r6;
public static class Pokazer
{
    private const string interest = "interest";
    private const string balance = "balance";
    private static PropertyInfo GetPropertyy(string key)
    {
        PropertyInfo propertyInfoInterest = typeof(Account).GetProperty("Interest", BindingFlags.NonPublic | BindingFlags.Instance);
        PropertyInfo propertyInfoBalance = typeof(Account).GetProperty("Balance", BindingFlags.NonPublic | BindingFlags.Instance);
        PropertyInfo retInfo = null;
        if (key == "balance") retInfo = propertyInfoBalance;
        else if (key == "interest") retInfo = propertyInfoInterest;
        return retInfo;
    }

    public static void ShowBalance(Account account)
    {
        Console.WriteLine("баланс: " + GetPropertyy(balance).GetValue(account));
    }

    public static void ShowInterest(Account account)
    {
        Console.WriteLine("процПрибыль: " + GetPropertyy(interest).GetValue(account));
    }
}