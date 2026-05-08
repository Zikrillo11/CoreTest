namespace CoreTest.Shared.DTOs.User;

public class UserForShortResultDto : BaseDto
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public string Password { get; set; }
    public string Username { get; set; }
    public string Skills { get; set; }
}
