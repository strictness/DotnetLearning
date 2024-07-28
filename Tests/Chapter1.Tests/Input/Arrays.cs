namespace Chapter1.Tests.Input;

public static class Arrays
{
    public static int[] Null => null;
        
    public static int[] Empty => [];

    public static int[] SingleElement => [1];

    /// <summary>
    /// 1, 0.
    /// </summary>
    public static int[] TwoElementsDesc => [1, 0];

    /// <summary>
    /// 0, 1.
    /// </summary>
    public static int[] TwoElementsAsc => [0, 1];

    /// <summary>
    /// 1, 0, 2, -1, 3.
    /// </summary>
    public static int[] ArrayRandom => [1, 0, 2, -1, 3];

    /// <summary>
    /// 1, -1, 1.
    /// </summary>
    public static int[] Array2Equal => [1, -1, 1 ];

    /// <summary>
    /// 1, 1, 1.
    /// </summary>
    public static int[] Array3Same => [1, 1, 1];
}