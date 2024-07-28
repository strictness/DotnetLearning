namespace Chapter1.Tests.Input.Insert;

public class InsertLastElementExpectations: InsertElementExpectations
{
    protected override IList<object[]> GetSpecificScenarios()
    {
        return new List<object[]>()
        {
            new object[] { Arrays.TwoElementsAsc, new[] { 0, 1, ElementToBeInserted } }
        };
    }
}