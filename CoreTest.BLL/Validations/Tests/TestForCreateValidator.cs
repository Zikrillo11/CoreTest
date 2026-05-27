using CoreTest.Shared.DTOs.Tests;
using FluentValidation;

namespace CoreTest.BLL.Validations.Tests
{
   public class TestForCreateValidator : AbstractValidator<TestForCreateDTO>
    {
        public TestForCreateValidator()
        {
            RuleFor(x =>x.Topic)
                .NotEmpty().WithMessage("Topic kiritilishi shart.")
                .MaximumLength(100).WithMessage("Topic uzunligi 100 belgidan oshmasligi kerak.");
            RuleFor(x => x.Title)
                .NotEmpty().WithMessage("Title kiritilishi shart.")
                .MaximumLength(200).WithMessage("Title uzunligi 200 belgidan oshmasligi kerak.");
            RuleFor(x =>x.UserId)
                .GreaterThan(0).WithMessage("UserId musbat bo'lishi kerak.");
             RuleFor(x => x.Questions)
                .NotEmpty().WithMessage("Savollar kiritilishi shart.");
            RuleFor(x => x.Title)
                .NotEmpty().WithMessage("Title kiritilishi shart.")
                .MaximumLength(200).WithMessage("Title uzunligi 200 belgidan oshmasligi kerak.");
        }
    }
}
