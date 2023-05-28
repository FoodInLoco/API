using FoodInLoco.Application.Enums;

namespace FoodInLoco.Application.Data.Models
{
    public sealed record UserModelResponse
    {
        public Guid Id { get; init; }

        public DateTime CreatedAt { get; init; }

        public DateTime? LastUpdatedAt { get; init; }

        public string FirstName { get; init; }

        public string LastName { get; init; }

        public string Email { get; init; }

        public string DDD { get; init; }

        public string PhoneNumber { get; init; }

        public string Password { get; set; }
        
        public string? Photo { get; set; }

        public List<RestaurantModelResponse>? Restaurants { get; init; }

        public List<ReservationModelResponse>? Reservations { get; init; }
    }
}
