using FoodInLoco.Application.Enums;

namespace FoodInLoco.Application.Data.Models
{
    public sealed record RestaurantModelResponse
    {
        public Guid Id { get; init; }

        public DateTime CreatedAt { get; init; }

        public DateTime? LastUpdatedAt { get; init; }

        public Guid UserId { get; init; }

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

        public Status Status { get; init; }

        public UserModelResponse? User { get; init; }

        public List<MenuModelResponse>? Menus { get; init; }

        public List<ReservationModelResponse>? Reservations { get; init; }

        public List<ReviewModelResponse>? Reviews { get; init; }

        public List<AttractionModelResponse>? Attractions { get; init; }
    }
}
