using System.Text;

namespace Homework7;

public static class TextTable
{
    public static string Build(string message, int padding)
    {
        if (string.IsNullOrEmpty(message))
        {
            return string.Empty;
        }

        var words = message.Split(Environment.NewLine);
        var longestWordLength = GetLongestWordLength(words);
        var length = longestWordLength + padding * 2;

        var table = new StringBuilder();
        table.AppendLine(BuildBorder(length));
        table.Append(BuildPaddingRows(length, padding));
        table.Append(BuildContentRows(words, longestWordLength, padding));
        table.Append(BuildPaddingRows(length, padding));
        table.AppendLine(BuildBorder(length));

        return table.ToString();
    }

    private static string BuildBorder(int length)
    {
        return "+" + new string('-', length) + "+";
    }

    private static string BuildPaddingRows(int length, int padding)
    {
        var paddingRow = "|" + new string(' ', length) + "|";
        var paddingRows = new StringBuilder();
        for (var i = 0; i < padding; i++)
        {
            paddingRows.AppendLine(paddingRow);
        }

        return paddingRows.ToString();
    }

    private static string BuildContentRows(string[] words, int longestWordLength, int padding)
    {
        var contentRows = new StringBuilder();
        foreach (var word in words)
        {
            contentRows.AppendLine("|"
                                   + new string(' ', padding)
                                   + word.PadRight(longestWordLength)
                                   + new string(' ', padding) + "|");
        }

        return contentRows.ToString();
    }

    private static int GetLongestWordLength(string[] words)
    {
        return words.Max(word => word.Length);
    }
}