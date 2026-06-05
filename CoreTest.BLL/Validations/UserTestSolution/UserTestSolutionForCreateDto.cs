using CoreTest.Shared.DTOs.UserTestSolutions;
using FluentValidation;

namespace CoreTest.BLL.Validations.UserTestSolutions;

public class UserTestSolutionsForCreateValidator : AbstractValidator<UserTestSolutionsForCreateDto>
{
    public UserTestSolutionsForCreateValidator()
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

        RuleFor(x => x.CreatedBy)
            .NotNull()
            .WithMessage("CreatedBy bo'sh bo'lishi mumkin emas");
    }
}