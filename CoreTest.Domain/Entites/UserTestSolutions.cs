using System.ComponentModel.DataAnnotations.Schema;

namespace CoreTest.Domain.Entites;

[Table("UserTestSolutions")]
public class UserTestSolution
{
    [Column("UserId")]
    public int UserId { get; set; }

    [Column("TestSolutionId")]
    public int TestSolutionId { get; set; }
}