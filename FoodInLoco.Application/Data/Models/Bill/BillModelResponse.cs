using FoodInLoco.Application.Enums;

namespace FoodInLoco.Application.Data.Models
{
    public sealed record BillModelResponse
    {
        public Guid Id { get; init; }

        public DateTime CreatedAt { get; init; }

        public DateTime? LastUpdatedAt { get; init; }

        public Guid TableId { get; init; }

        public Guid RestaurantId { get; init; }

        public string RestaurantName { get; init; }

        public int TableNumber { get; init; }

        public BillingStatus BillingStatus { get; init; }
        
        public Status Status { get; init; }

        public bool WaiterRequested { get; init; }

        public double? ValueAmount { get; init; }

        public List<OrderModelResponse>? Orders { get; init; }

        public List<UserModelResponse>? Users { get; init; }

        public List<UserModelResponse>? PendingUsers { get; init; }
    }
}
