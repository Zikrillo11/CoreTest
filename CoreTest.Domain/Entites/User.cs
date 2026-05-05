using System.ComponentModel.DataAnnotations.Schema;
namespace CoreTest.Domain.Entites;

[Table("Users")]
public class User
{
    [Column("id")]
    public int Id { get; set; }

    [Column("full_name")] 
    public string FullName { get; set; }

    [Column("password")]
    public string Password { get; set; }

    [Column("username")]
    public string Username { get; set; }

    [Column("Skills")]
    public string Skills { get; set; }

    public ICollection<Test> Tests { get; set; }
    public ICollection<UserTestSolution> UserTestSolutions { get; set; }
}