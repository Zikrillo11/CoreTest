namespace CoreTest.Shared.DTOs.TestSolution;

public class TestSolutionForShortResultDTO : BaseDto
{
    public long Id { get; set; }
    public long UserTestSolutionId { get; set; }
    public long TestId { get; set; }
    public double Score { get; set; }
    public int QuestionCount { get; set; }
}
