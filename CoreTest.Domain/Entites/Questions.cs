using System.ComponentModel.DataAnnotations.Schema;

namespace CoreTest.Domain.Entites;

[Table("Questions")]
public class Questions
{
    [Column("id")]
    public long Id { get; set; }
    [Column("Text")]
    public string Text { get; set; }
    [Column("Type")]
    public string Type { get; set; }
    [Column("Test_Id")]
    public long TestId { get; set; }
    [Column("Options")]
    public string Options { get; set; }
}
