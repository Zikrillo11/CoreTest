using CoreTest.Shared.DTOs.Questions;
using FluentValidation;

namespace CoreTest.BLL.Validations.Questions
{
    public class QuestionsForUpdateValidator : AbstractValidator<QuestionForUpdateDTO>
    {
        public QuestionsForUpdateValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("Id kiritilishi shart");
            RuleFor(x => x.TestId)
                .NotEmpty().WithMessage("TestId kiritilishi shart");
        }
    }
}
