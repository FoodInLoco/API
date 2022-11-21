namespace FoodInLoco.Application.Data.Models
{
    public sealed class UpdateRestaurantModelValidator : RestaurantModelValidator
    {
        public UpdateRestaurantModelValidator()
        {
            Id(); CompanyName(); TradingName(); Email(); DDD(); PhoneNumber(); Kids(); Photo();
        }
    }
}
