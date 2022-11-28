using FoodInLoco.Application.Enums;

namespace FoodInLoco.Application.Data.Models
{
    public sealed record ReservationModelResponse
    {
        public Guid Id { get; init; }

        public DateTime CreatedAt { get; init; }

        public DateTime? LastUpdatedAt { get; init; }

        public Guid RestaurantId { get; init; }

        public Guid UserId { get; init; }

        public string Description { get; init; }

        public short SeatQuantity { get; init; }

        public DateTime Date { get; init; }

        public Status Status { get; init; }

        public Status Confirmation { get; init; }

        public string? UserName { get; init; }

        public string? UserEmail { get; init; }

        public string? RestaurantName { get; init; }
    }
}
