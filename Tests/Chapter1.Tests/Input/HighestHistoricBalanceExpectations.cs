﻿using static Chapter1.Tests.Input.BalancesInput;

namespace Chapter1.Tests.Input;

public class HighestHistoricBalanceExpectations: TestExpectations
{
    protected override IEnumerable<object[]> GetInput()
    {
        return new List<object[]>
        {
            new object[]{Null, "N/A."},
            new object[]{Empty, "N/A."},
            new object[]{Person1Balance1, "Tom had the most money ever. ¤1." },
            new object[]{Person1Balance2, "Tom had the most money ever. ¤1." },
            new object[]{Person2Balance1, "Tom had the most money ever. ¤1." },
            new object[]{Person3Balance3, "Thor had the most money ever. ¤1002." },
            new object[]{Person3Same, "Tom, Gillie and Agnes had the most money ever. ¤1." }
        };
    }
}