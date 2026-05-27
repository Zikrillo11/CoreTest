using CoreTest.Shared.DTOs.Categories;
using FluentValidation;

namespace CoreTest.BLL.Validations.Categories
{
    public class CategoryForUpdateValidator : AbstractValidator<CategoryForUpdateDTO>
    {
        public CategoryForUpdateValidator() 
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .WithMessage("Id kiritilishi shart");
        }
    }
}
