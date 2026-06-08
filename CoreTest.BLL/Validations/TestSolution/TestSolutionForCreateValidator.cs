using CoreTest.Shared.DTOs.TestSolution;
using FluentValidation;
using System.Security.Cryptography.X509Certificates;

namespace CoreTest.BLL.Validations.TestSolution;

public class TestSolutionForCreateValidator : AbstractValidator<TestSolutionForCreateDTO>
{
    public TestSolutionForCreateValidator()
    {
       RuleFor(x => x.UserTestSolutionId)
            .NotEmpty().WithMessage("UserTestSolutionId is required.");
        RuleFor(x => x.TestId)
            .NotEmpty().WithMessage("TestId is required.");
        RuleFor(x => x.CreatedBy)
            .NotEmpty().WithMessage("CreatedBy is required.");
       
    }
}
