using FluentValidation;
using System.Text.RegularExpressions;

namespace FoodInLoco.Application.Data.Models
{
    public abstract class AttractionModelValidator : AbstractValidator<AttractionModel>
    {
        public void Id() => RuleFor(_ => _.Id).NotEmpty();

        public void Restaurant() => RuleFor(_ => _.RestaurantId).NotEmpty();

        public void Name() => RuleFor(_ => _.Name).NotEmpty();

        public void Description() => RuleFor(_ => _.Description).NotEmpty();

        public void Photo() => RuleFor(_ => _.Photo).NotEmpty().MaximumLength(1000);

        public void Date() => RuleFor(_ => _.Date).GreaterThanOrEqualTo(DateTime.Now);

        public void Cover() => RuleFor(_ => _.CoverTax).NotEmpty();

        public void Status() => RuleFor(_ => _.Status).NotEmpty();
    }
}
