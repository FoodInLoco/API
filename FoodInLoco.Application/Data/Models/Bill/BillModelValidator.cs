using FluentValidation;

namespace FoodInLoco.Application.Data.Models
{
    public abstract class BillModelValidator : AbstractValidator<BillModelRequest>
    {
        public void Id() => RuleFor(_ => _.Id).NotEmpty();

        public void Table() => RuleFor(_ => _.TableId).NotEmpty();

        public void BillingStatus() => RuleFor(_ => _.BillingStatus).Equals((int)Enums.BillingStatus.Paid);
    }
}
