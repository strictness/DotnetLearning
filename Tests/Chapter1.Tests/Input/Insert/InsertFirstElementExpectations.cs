namespace Chapter1.Tests.Input.Insert
{
    public class InsertFirstElementExpectations: InsertElementExpectations
    {
        protected override IList<object[]> GetSpecificScenarios()
        {
            return new List<object[]>
            {
                new object[] { Arrays.TwoElementsAsc, new[] { ElementToBeInserted, 0, 1 } }
            };
        }
    }
}
