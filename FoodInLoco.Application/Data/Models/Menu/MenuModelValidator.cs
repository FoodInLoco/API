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

        public void ExpirationDate() => RuleFor(_ => _.ExpirationDate).GreaterThanOrEqualTo(_ => _.InitialDate.Date).NotEmpty();

        public void HappyHour() => RuleFor(_ => _.HappyHour).NotEmpty().DependentRules(() =>
        {
            When(_ => _.HappyHour == true, () => 
            {
                RuleFor(_ => _.StartAt)
                    .NotEmpty().WithMessage("Hor�rio de in�cio n�o pode ser vazio, visto que � um card�pio de Happy Hour.");
                RuleFor(_ => _.EndAt)
                    .GreaterThan(_ => _.StartAt).WithMessage("O hor�rio de finaliza��o do Happy Hour n�o pode ser anterior ao hor�rio de in�cio.")
                    .NotEmpty().WithMessage("Hor�rio de finaliza��o n�o pode ser vazio, visto que � um card�pio de Happy Hour.");
            });
        });

        public void Status() => RuleFor(_ => _.Status).NotEmpty();
    }
}
