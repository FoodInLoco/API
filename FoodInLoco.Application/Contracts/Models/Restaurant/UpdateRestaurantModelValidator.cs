namespace FoodInLoco.Application.Contracts.Models
{
    public sealed class UpdateRestaurantModelValidator : RestaurantModelValidator
    {
        public UpdateRestaurantModelValidator()
        {
            Id(); CompanyName(); TradingName(); Email();
        }
    }
}
