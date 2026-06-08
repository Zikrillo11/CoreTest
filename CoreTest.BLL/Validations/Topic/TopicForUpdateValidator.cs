using CoreTest.Shared.DTOs.Topic;
using FluentValidation;

namespace CoreTest.BLL.Validations.Topic;

public class TopicForUpdateValidator : AbstractValidator<TopicForUpdateDTO>
{
    public TopicForUpdateValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty().WithMessage("Id is required.");
        RuleFor(x=> x.CategoryId)
            .NotEmpty().WithMessage("CategoryId is required");
        RuleFor(x => x.UpdatedBy)
            .NotEmpty().WithMessage("UpdatedBy is required.");
    }
}
