namespace CoreTest.Shared.DTOs.TestSolution;

public class TestSolutionForUpdateDTO
{
    public long Id { get; set; }
    public long UserTestSolutionId { get; set; }
    public long TestId { get; set; }
    public long? UpdatedBy { get; set; }
}
