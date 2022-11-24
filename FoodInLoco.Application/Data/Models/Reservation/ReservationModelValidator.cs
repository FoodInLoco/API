using FluentValidation;
using System.Text.RegularExpressions;

namespace FoodInLoco.Application.Data.Models
{
    public abstract class ReservationModelValidator : AbstractValidator<ReservationModelRequest>
    {
        public void Id() => RuleFor(_ => _.Id).NotEmpty();

        public void Restaurant() => RuleFor(_ => _.RestaurantId).NotEmpty();

        public void User() => RuleFor(_ => _.UserId).NotEmpty();

        public void Description() => RuleFor(_ => _.Description).MaximumLength(300).NotEmpty();

        public void SeatQuantity() => RuleFor(_ => _.SeatQuantity).GreaterThan((short)0).NotEmpty();

        public void Date() => RuleFor(_ => _.Date.Date).GreaterThanOrEqualTo(DateTime.Now.Date).NotEmpty();
    }
}
