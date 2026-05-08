using System.ComponentModel.DataAnnotations.Schema;

namespace CoreTest.Shared.DTOs;

public class OptionForCreateDTO
{

    public long Id { get; set; }
    public long QuestionId { get; set; }
    public long? CreatedBy { get; set; }

}
