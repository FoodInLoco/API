using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Data.ValueObjects;
using FoodInLoco.Application.Enums;

namespace FoodInLoco.Application.Data.Entities
{
    public class Bill : Entity<Guid>
    {
        public Bill
        (
            Guid tableId,
            BillingStatus billingStatus
        )
        {
            TableId = tableId;
            BillingStatus = billingStatus;
            CreatedAt = DateTime.UtcNow;
            Activate();
        }

        public Bill(Guid id) => Id = id;

        public Guid TableId { get; private set; }

        public Status Status { get; private set; }

        public BillingStatus BillingStatus { get; private set; }

        public Table Table { get; private set; }

        public ICollection<User> Users { get; private set; }

        public ICollection<Order> Orders { get; private set; }

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

        public bool IsActive() => Status == Status.Active;

        public void Update(BillingStatus billingStatus)
        {
            BillingStatus = billingStatus;
            LastUpdatedAt = DateTime.UtcNow;
        }

        public static implicit operator BillModelResponse(Bill bill)
        {
            if (bill is null)
                return null;

            return new BillModelResponse()
            {
                Id = bill.Id,
                CreatedAt = bill.CreatedAt,
                LastUpdatedAt = bill.LastUpdatedAt,
                TableId = bill.TableId,
                BillingStatus = bill.BillingStatus,
                Status = bill.Status,
                ValueAmount = bill.Orders.Sum(_ => _.Quantity * _.Item.Value)
            };
        }
    }
}
