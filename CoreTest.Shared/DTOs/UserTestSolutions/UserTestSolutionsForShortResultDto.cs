using System;
using System.Collections.Generic;
using System.Text;

namespace CoreTest.Shared.DTOs.UserTestSolutions;

public class UserTestSolutionsForShortResultDto : BaseDto
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int TestSolutionId { get; set; }
}
