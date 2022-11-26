using FluentValidation;
using System.Text.RegularExpressions;

namespace FoodInLoco.Application.Data.Models
{
    public abstract class ReviewModelValidator : AbstractValidator<ReviewModelRequest>
    {
        public void Id() => RuleFor(_ => _.Id).NotEmpty();

        public void Restaurant() => RuleFor(_ => _.RestaurantId).NotEmpty();

        public void Reservation() => RuleFor(_ => _.ReservationId).NotEmpty();

        public void Name() => RuleFor(_ => _.Name).MaximumLength(100).NotEmpty();

        public void Description() => RuleFor(_ => _.Description).MaximumLength(300).NotEmpty();

        public void Rate() => RuleFor(_ => _.Rate).NotEmpty();
    }
}
