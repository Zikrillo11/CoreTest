using CoreTest.Shared.DTOs;
using FluentValidation;

namespace CoreTest.BLL.Validations.Option;

public class OptionForCreateValidator : AbstractValidator<OptionForCreateDTO>
{
    public OptionForCreateValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty()
            .WithMessage("Id kiritilishi shart");
        RuleFor(x => x.QuestionId)
            .NotEmpty()
            .WithMessage("Savol Idsi kiritilishi shart");
    }
}
