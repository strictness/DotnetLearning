using System.Collections;
using static Chapter1.Tests.Input.Insert.InsertElementExpectations;

namespace Chapter1.Tests.Input.Insert;

public class InsertElementAtExpectations: IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        // Index out of bounds- returns original array.
        yield return [Arrays.Empty, 1, Arrays.Empty];
        yield return [Arrays.Empty, -1, Arrays.Empty];

        // Null or empty- create a new array with that element.
        yield return [Arrays.Empty, 0, new[] { ElementToBeInserted }];
        yield return [Arrays.Null, 0, new[] { ElementToBeInserted }];
            
        yield return [Arrays.TwoElementsDesc, 1, new[] { 1, ElementToBeInserted, 0 }];
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}