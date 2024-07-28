using System.Collections;

namespace Chapter1.Tests.Input;

/// <summary>
/// Array sorted in ascending order
/// </summary>
public class ArraySortExpectations: IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        // Null or empty array- returns itself.
        yield return [Arrays.Empty, Arrays.Empty];
        yield return [Arrays.Null, Arrays.Null];

        // Already sorted array- remains the same.
        yield return [Arrays.Array3Same, Arrays.Array3Same];
        yield return [Arrays.TwoElementsAsc, Arrays.TwoElementsAsc];
        yield return [Arrays.SingleElement, Arrays.SingleElement];

        // Actual sort.
        yield return [Arrays.TwoElementsDesc, Arrays.TwoElementsAsc];
        yield return [Arrays.ArrayRandom, new [] { -1, 0, 1, 2, 3 }];
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}