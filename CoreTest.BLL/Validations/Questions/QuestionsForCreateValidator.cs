using CoreTest.Shared.DTOs.Questions;
using FluentValidation;

namespace CoreTest.BLL.Validations.Questions
{
    public class QuestionsForCreateValidator : AbstractValidator<QuestionForCreateDTO>
    {
        public QuestionsForCreateValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .WithMessage("Id kiritilishi shart");
            RuleFor(x => x.TestId)
                .NotEmpty()
                .WithMessage("TestId kiritilishi shart");
        }
    }
}
