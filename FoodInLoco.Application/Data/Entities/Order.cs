using DotNetCore.Objects;
using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Data.ValueObjects;
using FoodInLoco.Application.Enums;

namespace FoodInLoco.Application.Data.Entities
{
    public class Order : Entity<Guid>
    {
        public Order
        (
            Guid billId,
            Guid userId,
            Guid itemId,
            int quantity,
            string message
        )
        {
            BillId = billId;
            UserId = userId;
            ItemId = itemId;
            Quantity = quantity;
            Message = message;
            CreatedAt = DateTime.UtcNow;
            Activate();
        }

        public Order(Guid id) => Id = id;

        public Guid BillId { get; private set; }

        public Guid UserId { get; private set; }

        public Guid ItemId { get; private set; }

        public int Quantity { get; private set; }

        public string Message { get; private set; }

        public Status Status { get; private set; }

        public bool Confirmed { get; private set; }

        public Bill Bill { get; private set; }

        public User User { get; private set; }

        public MenuItem Item { get; private set; }

        public void Activate()
        {
            Status = Status.Active;
            LastUpdatedAt = DateTime.UtcNow;
        }

        public void Inactivate()
        {
            Status = Status.Inactive;
            LastUpdatedAt = DateTime.UtcNow;
        }
        
        public void Confirm()
        {
            Confirmed = true;
            LastUpdatedAt = DateTime.UtcNow;
        }

        public bool IsActive() => Status == Status.Active;

        public void Update(int quantity, string message)
        {
            Quantity = quantity;
            Message = message;
        }

        public static implicit operator OrderModelResponse(Order order)
        {
            if (order is null)
                return null;

            return new OrderModelResponse()
            {
                Id = order.Id,
                CreatedAt = order.CreatedAt,
                LastUpdatedAt = order.LastUpdatedAt,
                BillId = order.BillId,
                UserId = order.UserId,
                MenuItemId = order.ItemId,
                Status = order.Status,
                Confirmed = order.Confirmed,
                ProductName = order.Item.NameDescription.Name,
                ProductDescription = order.Item.NameDescription.Description,
                ProductQuantity = order.Item.Quantity,
                ProductPhoto = order.Item.Photo,
                Quantity = order.Quantity,
                Message = order.Message,
                ValueAmount = order.Quantity * order.Item.Value
            };
        }
    }
}
