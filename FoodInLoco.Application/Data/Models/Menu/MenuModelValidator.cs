using FluentValidation;
using System.Text.RegularExpressions;

namespace FoodInLoco.Application.Data.Models
{
    public abstract class MenuModelValidator : AbstractValidator<MenuModel>
    {
        public void Id() => RuleFor(_ => _.Id).NotEmpty();

        public void Restaurant() => RuleFor(_ => _.RestaurantId).NotEmpty();

        public void Name() => RuleFor(_ => _.Name).MaximumLength(100).NotEmpty();

        public void Description() => RuleFor(_ => _.Description).MaximumLength(300).NotEmpty();

        public void Photo() => RuleFor(_ => _.Photo).MaximumLength(10000).NotEmpty();

        public void InitialDate() => RuleFor(_ => _.InitialDate.Date).GreaterThanOrEqualTo(DateTime.Now.Date).NotEmpty();

        public void ExpirationDate() => RuleFor(_ => _.ExpirationDate).NotEmpty();

        public void HappyHour() => RuleFor(_ => _.HappyHour).NotEmpty().DependentRules(() =>
        {
            When(_ => _.HappyHour == true, () => 
            {
                RuleFor(_ => _.StartAt)
                    .Matches(new Regex(@"^([0-1]?[0-9]|2[0-3]):[0-5][0-9]$")).WithMessage("Formato de horário preenchido é inválido.")
                    .NotEmpty();
                RuleFor(_ => _.EndAt)
                    .Matches(new Regex(@"^([0-1]?[0-9]|2[0-3]):[0-5][0-9]$")).WithMessage("Formato de horário preenchido é inválido.")
                    .NotEmpty();
            });
        });

        public void Status() => RuleFor(_ => _.Status).NotEmpty();
    }
}
