namespace CoreTest.Shared.DTOs.UserTestSolutions;

public class UserTestSolutionsForUpdateDto
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int TestSolutionId { get; set; }
    public long? UpdatedBy { get; set; }
    public bool IsActive { get; set; }
}
