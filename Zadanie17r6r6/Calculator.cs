namespace Zadanie17r6r6;
public static class Calculator
{
    private const string RaschetProcPribyli = "procc";
    private const string Interest = "interest";
    private const string Balance = "balance";
    private static PropertyInfo GetPropertyy(string key)
    {
        PropertyInfo propertyInfoInterest = typeof(Account).GetProperty("Interest", BindingFlags.NonPublic | BindingFlags.Instance);
        PropertyInfo propertyInfoBalance = typeof(Account).GetProperty("Balance", BindingFlags.NonPublic | BindingFlags.Instance);
        PropertyInfo retInfo;
        if (key == "balance") retInfo = propertyInfoBalance;
        else if (key == "interest") retInfo = propertyInfoInterest;
        else retInfo = null;
        return retInfo;
    }

    private static MethodInfo GetMet(string key)
    {
        MethodInfo methodInfoRaschetProcPribyli = typeof(Account).GetMethod("RaschetProcPribyli", BindingFlags.NonPublic | BindingFlags.Instance);
        MethodInfo retInf;
        if (key == "procc") retInf = methodInfoRaschetProcPribyli;
        else retInf = null;
        return retInf;
    }

    public static void CalculateInterest(Account account)
    {
        GetPropertyy(Interest).SetValue(account, GetMet(RaschetProcPribyli).Invoke(account, new object[] { (double)GetPropertyy(Balance).GetValue(account) }));
    }

    public static void PopolnenieSnyatie(Account account, double cash)
    {
        GetPropertyy(Balance).SetValue(account, (double)GetPropertyy(Balance).GetValue(account) + cash);
    }
}