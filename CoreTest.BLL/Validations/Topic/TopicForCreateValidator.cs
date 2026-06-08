using CoreTest.Shared.DTOs.Topic;
using FluentValidation;

namespace CoreTest.BLL.Validations.Topic;

public class TopicForCreateValidator : AbstractValidator<TopicForCreateDTO>
{
    public TopicForCreateValidator()
    { 
        RuleFor(x => x.CategoryId)
            .NotEmpty().WithMessage("CategoryId is required");
        RuleFor(x => x.CreatedBy)
            .NotEmpty().WithMessage("CreatedBy is required");
    }
}
