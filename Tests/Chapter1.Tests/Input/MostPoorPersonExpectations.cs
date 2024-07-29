using static Chapter1.Tests.Input.BalancesInput;

namespace Chapter1.Tests.Input;

public class MostPoorPersonExpectations : TestExpectations
{
    protected override IEnumerable<object[]> GetInput()
    {
        return new List<object[]>
        {
            new object[]{Null, "N/A."},
            new object[]{Empty, "N/A."},
            new object[]{Person1Balance1, "Tom has the least money. ¤1." },
            new object[]{Person1Balance2, "Tom has the least money. ¤0." },
            new object[]{Person2Balance1, "Gillie has the least money. ¤0." },
            new object[]{Person3Balance3, "Tom has the least money. -¤1." },
            new object[]{Person3Same, "Tom, Gillie and Agnes have the least money. ¤1." }
        };
    }
}