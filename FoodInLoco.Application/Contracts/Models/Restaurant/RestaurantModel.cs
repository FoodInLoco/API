namespace FoodInLoco.Application.Contracts.Models
{
    public sealed record RestaurantModel
    {
        public long Id { get; init; }

        public string CompanyName { get; init; }

        public string TradingName { get; init; }

        public string Email { get; init; }

        public string DDD { get; init; }

        public string PhoneNumber { get; init; }

        public AuthModel Auth { get; init; }
    }
}
