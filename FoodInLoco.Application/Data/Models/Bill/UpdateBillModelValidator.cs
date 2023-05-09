namespace FoodInLoco.Application.Data.Models
{
    public sealed class UpdateBillModelValidator : BillModelValidator
    {
        public UpdateBillModelValidator()
        {
            Id(); Table(); BillingStatus();
        }
    }
}
