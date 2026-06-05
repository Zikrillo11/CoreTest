using CoreTest.Shared.DTOs.UserTestSolutions;
using FluentValidation;

namespace CoreTest.BLL.Validations.UserTestSolutions;

public class UserTestSolutionsForUpdateValidator : AbstractValidator<UserTestSolutionsForUpdateDto>
{
    public UserTestSolutionsForUpdateValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty()
            .WithMessage("Id kiritilishi shart");

        RuleFor(x => x.UserId)
            .NotEmpty()
            .WithMessage("UserId kiritilishi shart");

        RuleFor(x => x.TestSolutionId)
            .NotEmpty()
            .WithMessage("TestSolutionId kiritilishi shart");

        RuleFor(x => x.UpdatedBy)
            .NotNull()
            .WithMessage("UpdatedBy bo'sh bo'lishi mumkin emas");

        RuleFor(x => x.IsActive)
            .NotNull()
            .WithMessage("IsActive qiymati bo'lishi shart");
    }
}