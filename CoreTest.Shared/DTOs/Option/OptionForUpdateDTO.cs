namespace CoreTest.Shared.DTOs;

public class OptionForUpdateDTO
{
    public long Id { get; set; }
    public long QuestionId { get; set; }
    public long? UpdatedBy { get; set; }
}
