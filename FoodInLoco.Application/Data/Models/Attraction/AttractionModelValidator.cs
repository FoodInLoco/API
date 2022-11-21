using FluentValidation;
using System.Text.RegularExpressions;

namespace FoodInLoco.Application.Data.Models
{
    public abstract class AttractionModelValidator : AbstractValidator<AttractionModel>
    {
        public void Id() => RuleFor(_ => _.Id).NotEmpty();

        public void Restaurant() => RuleFor(_ => _.RestaurantId).NotEmpty();

        public void Name() => RuleFor(_ => _.Name).MaximumLength(100).NotEmpty();

        public void Description() => RuleFor(_ => _.Description).MaximumLength(300).NotEmpty();

        public void Photo() => RuleFor(_ => _.Photo).MaximumLength(10000).NotEmpty();

        public void Date() => RuleFor(_ => _.Date.Date).GreaterThanOrEqualTo(DateTime.Now.Date).NotEmpty();

        public void Cover() => RuleFor(_ => _.CoverTax).NotEmpty();

        public void Status() => RuleFor(_ => _.Status).NotEmpty();
    }
}
