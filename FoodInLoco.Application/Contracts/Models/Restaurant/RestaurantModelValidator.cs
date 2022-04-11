using FluentValidation;
using System.Text.RegularExpressions;

namespace FoodInLoco.Application.Contracts.Models
{
    public abstract class RestaurantModelValidator : AbstractValidator<RestaurantModel>
    {
        public void Id() => RuleFor(user => user.Id).NotEmpty();

        public void CompanyName() => RuleFor(user => user.CompanyName).NotEmpty();

        public void TradingName() => RuleFor(user => user.TradingName).NotEmpty();

        public void Email() => RuleFor(user => user.Email).EmailAddress();

        public void DDD() => RuleFor(user => user.DDD)
            .Length(2).WithMessage("DDD should have 2 characteres.")
            .Matches(new Regex(@"\d{2}")).WithMessage("DDD not valid.");

        public void PhoneNumber() => RuleFor(user => user.PhoneNumber)
            .NotNull().WithMessage("Phone Number is required.")
            .NotEmpty().WithMessage("Phone Number should not be empty.")
            .MinimumLength(9).WithMessage("Phone Number should have at least 9 characters.")
            .MinimumLength(10).WithMessage("Phone Number shouldn't have more than 10 characters.")
            .Matches(new Regex(@"\d{5}-?\d{4}")).WithMessage("Phone Number not valid.");

        public void Auth() => RuleFor(user => user.Auth).SetValidator(new AuthModelValidator());
    }
}
