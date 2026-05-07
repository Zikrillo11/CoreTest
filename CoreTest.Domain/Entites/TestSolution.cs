using System.ComponentModel.DataAnnotations.Schema;
namespace CoreTest.Domain.Entites;
//TestSolution -> Id, UserTestSolutionId, TestId, Score, QuestionCount
public class TestSolution
{
    [Column("Id")]
    public long Id { get; set; }

    [Column("UserTestSolutionId")]
    public long UserTestSolutionId { get; set; }

    [Column("TestId")]
    public long TestId { get; set; }

    [Column("Score")]
    public double Score { get; set; }

    [Column("QuestionCount")]
    public int QuestionCount { get; set; }
}