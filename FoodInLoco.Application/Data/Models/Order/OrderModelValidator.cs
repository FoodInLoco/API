using FluentValidation;
using System.Text.RegularExpressions;

namespace FoodInLoco.Application.Data.Models
{
    public abstract class OrderModelValidator : AbstractValidator<OrderModelRequest>
    {
        public void Id() => RuleFor(_ => _.Id).NotEmpty();

        public void Bill() => RuleFor(_ => _.BillId).NotEmpty();

        public void User() => RuleFor(_ => _.UserId).NotEmpty();

        public void MenuItem() => RuleFor(_ => _.MenuItemId).NotEmpty();

        public void Quantity() => RuleFor(_ => _.Quantity).GreaterThan(0).NotEmpty();
    }
}
