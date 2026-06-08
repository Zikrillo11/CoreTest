namespace CoreTest.Contracts.Criteria.User;

public class UserCriteria : BaseCriteria
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string Skills { get; set; }

}
