using System.ComponentModel.DataAnnotations.Schema;
namespace CoreTest.Domain.Entites;
//Option -> Id, Text, QuestionId, IsCorrect, IsChanged
public class Option
{
    [Column("id")]
    public long Id { get; set; }

    [Column("Text")]
    public string Text { get; set; }

    [Column("QuestionId")]
    public long QuestionId { get; set; }

    [Column("IsCorrect")]
    public bool IsCorrect { get; set; } = false;

    [Column("IsChanged")]
    public bool IsChanged { get; set; } = false;
}