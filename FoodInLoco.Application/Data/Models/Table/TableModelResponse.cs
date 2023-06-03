using FoodInLoco.Application.Enums;

namespace FoodInLoco.Application.Data.Models
{
    public sealed record TableModelResponse
    {
        public Guid Id { get; init; }

        public DateTime CreatedAt { get; init; }

        public DateTime? LastUpdatedAt { get; init; }

        public Guid RestaurantId { get; init; }

        public byte[] QrCode { get; init; }

        public int Number { get; init; }
        
        public bool Occupied { get; init; }

        public Status Status { get; init; }

        public string? RestaurantName { get; init; }
    }
}
