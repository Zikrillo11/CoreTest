using CoreTest.Shared.DTOs.Tests;
using FluentValidation;

namespace CoreTest.BLL.Validations.Tests
{
    public class TestFOrUpdateValidator : AbstractValidator<TestForUpdateDTO>
    {
        public TestFOrUpdateValidator()
        {
            RuleFor(x => x.Topic)
                .NotEmpty().WithMessage("Topic kiritilishi shart.")
                .MaximumLength(100).WithMessage("Topic uzunligi 100 belgidan oshmasligi kerak.");
            RuleFor(x => x.Title)
               .NotEmpty().WithMessage("Title kiritilishi shart.")
               .MaximumLength(200).WithMessage("Title uzunligi 200 belgidan oshmasligi kerak.");
            RuleFor(x => x.UserId)
                .GreaterThan(0).WithMessage("UserId musbat bo'lishi kerak.");
            RuleFor(x => x.Id)
                .GreaterThan(0).WithMessage("Id musbat bo'lishi kerak.");

        }
    }
}
