namespace FoodInLoco.Application.Data.Models
{
    public sealed record OrderModelRequest
    {
        public Guid Id { get; init; }

        public Guid BillId { get; init; }

        public Guid UserId { get; init; }

        public Guid MenuItemId { get; init; }

        public int Quantity { get; init; }

        public string Message { get; init; }
    }
}
