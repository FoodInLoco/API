using FluentValidation;

namespace FoodInLoco.Application.Data.Models
{
    public abstract class BillUserModelValidator : AbstractValidator<BillUserModelRequest>
    {
        public void BillId() => RuleFor(_ => _.BillId).NotEmpty();

        public void UserId() => RuleFor(_ => _.UserId).NotEmpty();
    }
}
