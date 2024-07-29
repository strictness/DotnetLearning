namespace Chapter1.Tests.Input;

public static class BalancesInput
{
    public static string[] Null => null;
    public static string[] Empty => [];
    /// <summary>
    /// "Tom"
    /// </summary>
    public static string[] Person1NoBalance => ["Tom"];
    /// <summary>
    /// "Tom, 1"
    /// </summary>
    public static string[] Person1Balance1 => ["Tom, 1"];
    /// <summary>
    /// "Tom, 1, 0"
    /// </summary>
    public static string[] Person1Balance2 => ["Tom, 1, 0"];
    /// <summary>
    /// "Tom, 1", "Gillie, 0"
    /// </summary>
    public static string[] Person2Balance1 => ["Tom, 1", "Gillie, 0"];
    /// <summary>
    /// "Tom, 1, 0", "Gillie, 0, 1"
    /// </summary>
    public static string[] Person2Balance2 => ["Tom, 1, 0", "Gillie, 0, 1"];
    /// <summary>
    /// "Tom, 1, 3, -1", "Gillie, 2, 3, 1", "Thor, 1000, 1001, 1002"
    /// </summary>
    public static string[] Person3Balance3 => ["Tom, 1, 3, -1", "Gillie, 2, 3, 1", "Thor, 1000, 1001, 1002"];
    /// <summary>
    /// "Tom, 1", "Gillie 2, 1", "Thor"
    /// </summary>
    public static string[] Mixed => ["Tom, 1", "Gillie 2, 1", "Thor"];
    /// <summary>
    /// "Tom, 1", "Gillie, 1", "Agnes, 1"
    /// </summary>
    public static string[] Person3Same => ["Tom, 1", "Gillie, 1", "Agnes, 1"];
}