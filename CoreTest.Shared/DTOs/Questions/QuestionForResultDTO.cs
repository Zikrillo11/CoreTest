using CoreTest.Domain.Entites;

namespace CoreTest.Shared.DTOs.Questions;

public class QuestionForResultDTO : BaseDto
{
    public long Id { get; set; }
    public string Text { get; set; }
    public string Type { get; set; }
    public long TestId { get; set; }
    public ICollection<Option> Options { get; set; }
}
