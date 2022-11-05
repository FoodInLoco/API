using FluentValidation;
using System.Text.RegularExpressions;

namespace FoodInLoco.Application.Data.Models
{
    public abstract class MenuItemModelValidator : AbstractValidator<MenuItemModel>
    {
        public void Id() => RuleFor(_ => _.Id).NotEmpty();

        public void Menu() => RuleFor(_ => _.MenuId).NotEmpty();

        public void Name() => RuleFor(_ => _.Name).NotEmpty();

        public void Description() => RuleFor(_ => _.Description).NotEmpty();

        public void Photo() => RuleFor(_ => _.Photo).NotEmpty();

        public void Quantity() => RuleFor(_ => _.Quantity).NotEmpty();

        public void Value() => RuleFor(_ => _.Value).NotEmpty();

        public void Status() => RuleFor(_ => _.Status).NotEmpty();
    }
}
