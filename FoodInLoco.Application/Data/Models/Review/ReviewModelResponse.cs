using FoodInLoco.Application.Enums;

namespace FoodInLoco.Application.Data.Models
{
    public sealed record ReviewModelResponse
    {
        public Guid Id { get; init; }

        public DateTime CreatedAt { get; init; }

        public DateTime? LastUpdatedAt { get; init; }

        public Guid RestaurantId { get; init; }

        public Guid ReservationId { get; init; }

        public Guid UserId { get; init; }

        public string Name { get; init; }

        public string Description { get; init; }

        public Rate Rate { get; init; }

        public Status Status { get; init; }

        public string? UserName { get; init; }

        public string? UserEmail { get; init; }

        public string? RestaurantName { get; init; }
    }
}
