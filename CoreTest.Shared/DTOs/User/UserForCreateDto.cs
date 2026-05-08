using System.ComponentModel.DataAnnotations.Schema;

namespace CoreTest.Shared.DTOs.User;

public class UserForCreateDto
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public string Password { get; set; }
    public string Username { get; set; }
    public long? CreatedBy { get; set; }
}
