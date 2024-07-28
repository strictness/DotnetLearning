using System.Collections;

namespace Chapter1.Tests.Input.Remove;

public class RemoveElementAtExpectations : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        const int unimportant = 0;

        // Empty or null- return original.
        yield return [Arrays.Empty, unimportant, Arrays.Empty];
        yield return [Arrays.Null, unimportant, Arrays.Null];

        // Invalid index- return original.
        yield return [Arrays.TwoElementsAsc, -1, Arrays.TwoElementsAsc];
        yield return [Arrays.TwoElementsAsc, 2, Arrays.TwoElementsAsc];

        // First.
        yield return [Arrays.TwoElementsAsc, 0, new[] { 1 }];
        // Last.
        yield return [Arrays.TwoElementsAsc, 1, new[] { 0 }];
        // Middle.
        yield return [Arrays.ArrayRandom, 2, new[] { 1, 0, -1, 3 }];
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}