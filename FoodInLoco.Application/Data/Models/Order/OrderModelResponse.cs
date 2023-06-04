using FoodInLoco.Application.Enums;

namespace FoodInLoco.Application.Data.Models
{
    public sealed record OrderModelResponse
    {
        public Guid Id { get; init; }

        public DateTime CreatedAt { get; init; }

        public DateTime? LastUpdatedAt { get; init; }

        public Guid BillId { get; init; }

        public Guid UserId { get; init; }

        public Guid MenuItemId { get; init; }

        public string ProductName { get; init; }

        public string ProductDescription { get; init; }

        public int ProductQuantity { get; init; }

        public string ProductPhoto { get; init; }

        public int Quantity { get; init; }
        
        public string? Message { get; init; }

        public Status Status { get; init; }

        public bool Confirmed { get; init; }

        public double? ValueAmount { get; init; }
    }
}
