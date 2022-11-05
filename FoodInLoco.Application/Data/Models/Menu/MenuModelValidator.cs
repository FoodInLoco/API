using FluentValidation;
using System.Text.RegularExpressions;

namespace FoodInLoco.Application.Data.Models
{
    public abstract class MenuModelValidator : AbstractValidator<MenuModel>
    {
        public void Id() => RuleFor(_ => _.Id).NotEmpty();

        public void Restaurant() => RuleFor(_ => _.RestaurantId).NotEmpty();

        public void Name() => RuleFor(_ => _.Name).NotEmpty();

        public void Description() => RuleFor(_ => _.Description).NotEmpty();

        public void Photo() => RuleFor(_ => _.Photo).NotEmpty();

        public void InitialDate() => RuleFor(_ => _.InitialDate).NotEmpty();

        public void ExpirationDate() => RuleFor(_ => _.ExpirationDate).NotEmpty();

        public void HappyHour() => RuleFor(_ => _.HappyHour).NotEmpty();

        public void StartAt() => RuleFor(_ => _.StartAt).NotEmpty();

        public void EndAt() => RuleFor(_ => _.EndAt).NotEmpty();
        
        public void Status() => RuleFor(_ => _.Status).NotEmpty();
    }
}
