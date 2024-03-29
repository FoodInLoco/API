using FoodInLoco.Application.Enums;

namespace FoodInLoco.Application.Data.Models
{
    public sealed record RestaurantModelRequest
    {
        public Guid Id { get; init; }

        public string CompanyName { get; init; }

        public string TradingName { get; init; }

        public string Email { get; init; }

        public string DDD { get; init; }

        public string PhoneNumber { get; init; }

        public string State { get; init; }

        public string City { get; init; }

        public string ZipCode { get; init; }

        public string Street { get; init; }

        public long? Number { get; init; }

        public string? Complement { get; init; }

        public bool Kids { get; init; }

        public string? Photo { get; init; }

        public string Password { get; set; }

    }
}
