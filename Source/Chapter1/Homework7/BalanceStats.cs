namespace Homework7;

public static class BalanceStats
{
    public static string FindHighestBalanceEver(string[] peopleAndBalances) => "";

    public static string FindPersonWithBiggestLoss(string[] peopleAndBalances) => "";

    public static string FindRichestPerson(string[]? peopleAndBalances)
    {
        if (peopleAndBalances == null || peopleAndBalances.Length == 0) return "N/A.";

        var balanceHistory = peopleAndBalances.Select(ProcessBalanceHistory).ToList();
        var richestPeople = FindPeopleWithExtremeBalance(balanceHistory, true);

        var richestPeopleNames = richestPeople.Select(x => x.Keys.First()).ToList();
        var richestPersonBalance = richestPeople.First().Values.Last().Last();

        return FormatResult(
            richestPeopleNames,
            richestPersonBalance,
            "is the richest person",
            "are the richest people");
    }

    public static string FindMostPoorPerson(string[] peopleAndBalances)
    {
        if (peopleAndBalances == null || peopleAndBalances.Length == 0) return "N/A.";

        var balanceHistory = peopleAndBalances.Select(ProcessBalanceHistory).ToList();
        var poorestPeople = FindPeopleWithExtremeBalance(balanceHistory, false);

        var poorestPeopleNames = poorestPeople.Select(x => x.Keys.First()).ToList();
        var poorestPersonBalance = poorestPeople.First().Values.Last().Last();

        return FormatResult(
            poorestPeopleNames,
            poorestPersonBalance,
            "has the least money",
            "have the least money",
            poorestPersonBalance < 0);
    }

    private static Dictionary<string, List<float>> ProcessBalanceHistory(string balanceString)
    {
        var parts = balanceString.Split(", ");
        return new Dictionary<string, List<float>> { { parts[0], parts[1..].Select(float.Parse).ToList() } };
    }

    private static List<Dictionary<string, List<float>>> FindPeopleWithExtremeBalance(
        List<Dictionary<string, List<float>>> balanceHistory,
        bool findMax)
    {
        var extremeBalance = findMax
            ? balanceHistory.Max(x => x.Values.Last().Last())
            : balanceHistory.Min(x => x.Values.Last().Last());
        return balanceHistory.Where(x => x.Values.Last().Last() == extremeBalance).ToList();
    }

    private static string FormatResult(
        List<string> names,
        float balance,
        string singular,
        string plural,
        bool isNegative = false)
    {
        var namesString = names.Count > 1
            ? string.Join(", ", names.Take(names.Count - 1)) + $" and {names.Last()}"
            : names.First();
        var balanceSign = isNegative ? "-" : "";
        return names.Count == 1
            ? $"{namesString} {singular}. {balanceSign}¤{Math.Abs(balance)}."
            : $"{namesString} {plural}. {balanceSign}¤{Math.Abs(balance)}.";
    }
}