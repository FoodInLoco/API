namespace FoodInLoco.Application.Data.Models
{
    public sealed class AddRestaurantModelValidator : RestaurantModelValidator
    {
        public AddRestaurantModelValidator()
        {
            CompanyName(); TradingName(); Email(); DDD(); PhoneNumber(); Auth();
        }
    }
}
