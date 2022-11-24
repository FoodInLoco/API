using FluentValidation;
using System.Text.RegularExpressions;

namespace FoodInLoco.Application.Data.Models
{
    public abstract class AttractionModelValidator : AbstractValidator<AttractionModelRequest>
    {
        public void Id() => RuleFor(_ => _.Id).NotEmpty();

        public void Restaurant() => RuleFor(_ => _.RestaurantId).NotEmpty();

        public void Name() => RuleFor(_ => _.Name).MaximumLength(100).NotEmpty();

        public void Description() => RuleFor(_ => _.Description).MaximumLength(300).NotEmpty();

        public void Date() => RuleFor(_ => _.Date.Date).GreaterThanOrEqualTo(DateTime.Now.Date).NotEmpty();

        public void Cover() => When(_ => _.CoverTax.HasValue, () =>
        {
            RuleFor(_ => _.CoverTax).NotEmpty();
        });

        public void Photo() => When(_ => !String.IsNullOrEmpty(_.Photo), () =>
        {
            RuleFor(_ => _.Photo).MaximumLength(10000).NotEmpty();
        });
    }
}
