using System.ComponentModel.DataAnnotations.Schema;

namespace CoreTest.Domain.Entites;

[Table("Test")]
public class Test
{
    [Column("id")]
    public long Id { get; set; }
    [Column("title")]
    public string Title { get; set; }
    [Column("description")]
    public string Descriiption { get; set; }
    [Column("questions")]
    public string Questions { get; set; }
    [Column("user_id")]
    public long UserId { get; set; }
    [Column("topic")]
    public string Topic { get; set; }
    [Column("minpersantage")]
    public long MinPersantage { get; set; }
}
