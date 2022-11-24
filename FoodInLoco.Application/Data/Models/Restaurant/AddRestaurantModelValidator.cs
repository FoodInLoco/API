namespace FoodInLoco.Application.Data.Models
{
    public sealed class AddRestaurantModelValidator : RestaurantModelValidator
    {
        public AddRestaurantModelValidator()
        {
            User(); CompanyName(); TradingName(); Email(); DDD(); PhoneNumber(); Kids(); Photo();
        }
    }
}
