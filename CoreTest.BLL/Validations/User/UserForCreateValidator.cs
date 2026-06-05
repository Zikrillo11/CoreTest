using CoreTest.Shared.DTOs.User;
using FluentValidation;

namespace CoreTest.BLL.Validations.Users;

public class UserForCreateValidator : AbstractValidator<UserForCreateDto>
{
    public UserForCreateValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty()
            .WithMessage("Id kiritilishi shart");

        RuleFor(x => x.FullName)
            .NotEmpty()
            .WithMessage("To'liq ism kiritilishi shart")
            .MinimumLength(5)
            .WithMessage("FullName kamida 5 ta belgidan iborat bo'lishi kerak")
            .MaximumLength(100)
            .WithMessage("FullName maksimal 100 ta belgidan iborat bo'lishi kerak");

        RuleFor(x => x.Username)
            .NotEmpty()
            .WithMessage("Username kiritilishi shart")
            .MinimumLength(3)
            .WithMessage("Username kamida 3 ta belgidan iborat bo'lishi kerak")
            .MaximumLength(50)
            .WithMessage("Username maksimal 50 ta belgidan iborat bo'lishi kerak");

        RuleFor(x => x.Password)
            .NotEmpty()
            .WithMessage("Password kiritilishi shart")
            .MinimumLength(6)
            .WithMessage("Password kamida 6 ta belgidan iborat bo'lishi kerak");

        RuleFor(x => x.CreatedBy)
            .NotNull()
            .WithMessage("CreatedBy bo'sh bo'lishi mumkin emas");
    }
}