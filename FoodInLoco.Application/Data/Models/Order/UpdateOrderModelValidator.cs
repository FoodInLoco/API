namespace FoodInLoco.Application.Data.Models
{
    public sealed class UpdateOrderModelValidator : OrderModelValidator
    {
        public UpdateOrderModelValidator()
        {
            Id(); Bill(); User(); MenuItem(); Quantity();
        }
    }
}
