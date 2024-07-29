namespace Homework7;

public class Program
{
    public static void Main()
    {
        var peopleAndBalances = PeoplesBalances.Balances;
        const int padding = 3;

        PrintTable(BalanceStats.FindHighestBalanceEver(peopleAndBalances), padding);
        PrintTable(BalanceStats.FindPersonWithBiggestLoss(peopleAndBalances), padding);
        PrintTable(BalanceStats.FindRichestPerson(peopleAndBalances), padding);
        PrintTable(BalanceStats.FindMostPoorPerson(peopleAndBalances), padding);
    }

    private static void PrintTable(string message, int padding)
    {
        Console.WriteLine(TextTable.Build(message, padding));
    }
}