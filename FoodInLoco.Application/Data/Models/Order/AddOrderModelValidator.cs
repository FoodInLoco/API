namespace FoodInLoco.Application.Data.Models
{
    public sealed class AddOrderModelValidator : OrderModelValidator
    {
        public AddOrderModelValidator()
        {
            Bill(); MenuItem(); Quantity();
        }
    }
}
