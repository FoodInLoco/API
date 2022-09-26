using FluentValidation;

namespace FoodInLoco.Application.Data.Models
{
    public sealed class MenuModelValidator : AbstractValidator<MenuModel>
    {
        public MenuModelValidator()
        {
            RuleFor(auth => auth.Login).NotEmpty();
            RuleFor(auth => auth.Password).NotEmpty();
            RuleFor(auth => auth.Roles).NotEmpty();
        }
    }
}
