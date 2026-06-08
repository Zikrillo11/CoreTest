namespace CoreTest.Shared.DTOs.Questions;

public class QuestionForShortResultDTO : BaseDto
{
    public long Id { get; set; }
    public long TestId { get; set; }
    public string Text { get; set; }
    public string Type { get; set; }
}
