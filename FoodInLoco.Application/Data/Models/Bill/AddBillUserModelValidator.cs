namespace FoodInLoco.Application.Data.Models
{
    public sealed class AddBillUserModelValidator : BillUserModelValidator
    {
        public AddBillUserModelValidator()
        {
            BillId();
        }
    }
}
