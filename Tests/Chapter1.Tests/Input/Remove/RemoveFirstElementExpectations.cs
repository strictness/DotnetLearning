namespace Chapter1.Tests.Input.Remove
{
    public class RemoveFirstElementExpectations: RemoveElementExpectations
    {
        protected override IList<object[]> GetSpecificScenarios()
        {
            return new List<object[]>()
            {
                new object[] { Arrays.TwoElementsAsc, new[] { 1 } }
            };
        }
    }
}
