namespace CoreTest.Shared.DTOs.Topic;

public class TopicForShortResultDTO : BaseDto
{
    public long Id { get; set; }
    public string Text { get; set; }
    public long CategoryId { get; set; }
}
