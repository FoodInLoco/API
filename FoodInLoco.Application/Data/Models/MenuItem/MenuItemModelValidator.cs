using FluentValidation;
using System.Text.RegularExpressions;

namespace FoodInLoco.Application.Data.Models
{
    public abstract class MenuItemModelValidator : AbstractValidator<MenuItemModelRequest>
    {
        public void Id() => RuleFor(_ => _.Id).NotEmpty();

        public void Menu() => RuleFor(_ => _.MenuId).NotEmpty();

        public void Name() => RuleFor(_ => _.Name).MaximumLength(100).NotEmpty();

        public void Description() => RuleFor(_ => _.Description).MaximumLength(300).NotEmpty();

        public void Photo() => When(_ => String.IsNullOrEmpty(_.Photo), () =>
        {
            RuleFor(_ => _.Photo).MaximumLength(10000).NotEmpty();
        });

        public void Quantity() => RuleFor(_ => _.Quantity).NotEmpty();

        public void Value() => RuleFor(_ => _.Value).NotEmpty();
    }
}
