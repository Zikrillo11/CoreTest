using CoreTest.Shared.DTOs.TestSolution;
using FluentValidation;

namespace CoreTest.BLL.Validations.TestSolution;

public class TestSolutionForUpdateValidator : AbstractValidator<TestSolutionForUpdateDTO>
{
    public TestSolutionForUpdateValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty().WithMessage("Id is required.");      
        RuleFor(x => x.UserTestSolutionId)
            .NotEmpty().WithMessage("UserTestSolutionId is required.");
        RuleFor(x => x.TestId)
            .NotEmpty().WithMessage("TestId is required.");
    }
}
