using System.ComponentModel.DataAnnotations.Schema;

namespace CoreTest.Domain.Entites;
//Topic -> Id, Text, CategoryId
public class Topic
{
    [Column("id")]
    public long Id { get; set; }

    [Column("Text")]
    public string Text { get; set; }

    [Column("CategoryId")]
    public long CategoryId { get; set; }
}
