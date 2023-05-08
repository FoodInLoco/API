using FluentValidation;
using System.Text.RegularExpressions;

namespace FoodInLoco.Application.Data.Models
{
    public abstract class TableModelValidator : AbstractValidator<TableModelRequest>
    {
        public void Id() => RuleFor(_ => _.Id).NotEmpty();

        public void Restaurant() => RuleFor(_ => _.RestaurantId).NotEmpty();

        public void Number() => RuleFor(_ => _.Number).GreaterThan(0).NotEmpty();
    }
}
