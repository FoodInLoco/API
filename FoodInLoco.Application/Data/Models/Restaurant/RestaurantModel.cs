namespace FoodInLoco.Application.Data.Models
{
    public sealed record RestaurantModel
    {
        public long Id { get; init; }

        public string CompanyName { get; init; }

        public string TradingName { get; init; }

        public string Email { get; init; }

        public string DDD { get; init; }

        public string PhoneNumber { get; init; }

        public string State { get; init; }

        public string City { get; init; }

        public string ZipCode { get; init; }

        public string Street { get; init; }

        public long Number { get; init; }

        public string Complement { get; init; }

        public AuthModel? Auth { get; init; }
    }
}
