namespace FoodInLoco.Application.Contracts.Models
{
    public sealed class AddRestaurantModelValidator : RestaurantModelValidator
    {
        public AddRestaurantModelValidator()
        {
            CompanyName(); TradingName(); Email(); DDD(); PhoneNumber(); Auth();
        }
    }
}
