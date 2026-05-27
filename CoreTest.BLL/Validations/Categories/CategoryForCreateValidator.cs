using CoreTest.Shared.DTOs.Categories;
using FluentValidation;

namespace CoreTest.BLL.Validations.Categories;

public class CategoryForCreateValidator : AbstractValidator<CategoryForCreateDTO>
{
    public CategoryForCreateValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty()
            .WithMessage("Id kiritilishi shart");
        RuleFor(x => x.Text)
            .MaximumLength(100)
            .WithMessage("Text maksimal 100 ta belgidan iborat bo'lishi kerak");
        RuleFor(x =>x.Text)
            .MinimumLength(10)
            .WithMessage("Text minimal 10 ta belgidan iborat bo'lishi kerak");

    }
}
