namespace Homework7;

public static class BalanceStats
{
    /// <summary>
    /// Return name and balance(current) of person who had the biggest historic balance.
    /// </summary>
    public static string FindHighestBalanceEver(string[] peopleAndBalances)
    {
        return "";
    }

    /// <summary>
    /// Return name and loss of a person with a biggest loss (balance change negative).
    /// </summary>
    public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
    {
        return "";
    }

    /// <summary>
    /// Return name and current money of the richest person.
    /// </summary>
    public static string FindRichestPerson(string[]? peopleAndBalances)
    {
        if (peopleAndBalances == null || peopleAndBalances.Length == 0)
        {
            return "N/A.";
        }

        var balanceHistory = peopleAndBalances.Select(ProcessBalanceHistory).ToList();
        var richestPeopleRows = FindRichestPeople(balanceHistory);

        var richestPeopleNames = richestPeopleRows.Select(x => x.Keys.First()).ToList();
        var richestPersonBalance = richestPeopleRows.First().Values.Last().Last();

        var richestPeopleNamesString = FormatRichestPeopleNames(richestPeopleNames);

        return richestPeopleNames.Count == 1
            ? $"{richestPeopleNamesString} is the richest person. ¤{richestPersonBalance}."
            : $"{richestPeopleNamesString} are the richest people. ¤{richestPersonBalance}.";
    }

    /// <summary>
    /// Return name and current money of the most poor person.
    /// </summary>
    public static string FindMostPoorPerson(string[] peopleAndBalances)
    {
        return "";
    }

    private static Dictionary<string, List<float>> ProcessBalanceHistory(string balanceString)
    {
        var balance = balanceString.Split(", ");
        var balanceHistory = balance[1..].Select(float.Parse).ToList();
        return new Dictionary<string, List<float>> { { balance[0], balanceHistory } };
    }

    private static List<Dictionary<string, List<float>>> FindRichestPeople(List<Dictionary<string, List<float>>> balanceHistory)
    {
        var maxBalance = balanceHistory.Max(x => x.Values.Last().Last());
        return balanceHistory.Where(x => x.Values.Last().Last() == maxBalance).ToList();
    }

    private static string FormatRichestPeopleNames(List<string> richestPeopleNames)
    {
        if (richestPeopleNames.Count > 1)
        {
            var lastPerson = richestPeopleNames.Last();
            richestPeopleNames.RemoveAt(richestPeopleNames.Count - 1);
            return string.Join(", ", richestPeopleNames) + $" and {lastPerson}";
        }
        return richestPeopleNames.First();
    }
}