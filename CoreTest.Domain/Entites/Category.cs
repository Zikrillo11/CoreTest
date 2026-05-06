using System.ComponentModel.DataAnnotations.Schema;

namespace CoreTest.Domain.Entites;

[Table("Category")]
public class Category
{
    [Column("Id")]
    public long Id { get; set; }
    [Column("Text")]
    public string Text { get; set; }
}
