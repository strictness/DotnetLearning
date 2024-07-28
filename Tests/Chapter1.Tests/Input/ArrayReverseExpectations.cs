using System.Collections;

namespace Chapter1.Tests.Input;

class ArrayReverseExpectations: IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        // Null or empty array- returns itself.
        yield return [Arrays.Empty, Arrays.Empty];
        yield return [Arrays.Null, Arrays.Null];

        // Arrays with all the same elements- returns itself.
        yield return [Arrays.Array3Same, Arrays.Array3Same];
        yield return [Arrays.SingleElement, Arrays.SingleElement];

        // Actual reverse order.
        yield return [Arrays.TwoElementsAsc, Arrays.TwoElementsDesc];
        yield return [Arrays.TwoElementsDesc, Arrays.TwoElementsAsc];
        yield return [Arrays.ArrayRandom, new [] { 3, -1, 2, 0, 1 }];
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}