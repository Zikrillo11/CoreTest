using System.ComponentModel.DataAnnotations.Schema;

namespace CoreTest.Shared.DTOs.UserTestSolutions;

public class UserTestSolutionsForResultDto : BaseDto
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int TestSolutionId { get; set; }
}
