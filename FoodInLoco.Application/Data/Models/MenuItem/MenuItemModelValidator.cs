using FluentValidation;

namespace FoodInLoco.Application.Data.Models
{
    public sealed class MenuItemModelValidator : AbstractValidator<MenuItemModel>
    {
        public MenuItemModelValidator()
        {
            RuleFor(auth => auth.Login).NotEmpty();
            RuleFor(auth => auth.Password).NotEmpty();
            RuleFor(auth => auth.Roles).NotEmpty();
        }
    }
}
