using CoreTest.Shared.DTOs;
using FluentValidation;

namespace CoreTest.BLL.Validations.Option;

public class OptionForUpdateValidator : AbstractValidator<OptionForUpdateDTO>
{
    public OptionForUpdateValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty()
            .WithMessage("Id kiritilishi shart");
        RuleFor(x => x.QuestionId)
            .NotEmpty()
            .WithMessage("Savol Idsi kiritilishi shart");
    }
}
