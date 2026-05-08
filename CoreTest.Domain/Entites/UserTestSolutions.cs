using System.ComponentModel.DataAnnotations.Schema;

namespace CoreTest.Domain.Entites;

[Table("UserTestSolutions")]
public class UserTestSolution
{
    [Column("Id")]
    public int Id { get; set; }
    [Column("UserId")]
    public int UserId { get; set; }
     
    [Column("TestSolutionId")]
    public int TestSolutionId { get; set; }
}