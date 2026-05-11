namespace CoreTest.Shared.DTOs;

public class OptionForResultDTO : BaseDto
{
    public long Id { get; set; }
    public string Text { get; set; }
    public long QuestionId { get; set; }
    public bool IsCorrect { get; set; } = false;
    public bool IsChanged { get; set; } = false;

}
