using FoodInLoco.Application.Data.Models;
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
            ActivateWaiter();
        }

        public Bill(Guid id) => Id = id;

        public Guid TableId { get; private set; }

        public Status Status { get; private set; }

        public BillingStatus BillingStatus { get; private set; }

        public bool WaiterRequested { get; private set; }

        public Table Table { get; private set; }

        public ICollection<BillUser> BillUsers { get; private set; }

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

        public void ActivateWaiter()
        {
            WaiterRequested = true;
            LastUpdatedAt = DateTime.UtcNow;
        }

        public void InactivateWaiter()
        {
            WaiterRequested = false;
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
                RestaurantId = bill.Table.RestaurantId,
                RestaurantName = bill.Table.Restaurant.Company.TradingName,
                TableNumber = bill.Table.Number,
                BillingStatus = bill.BillingStatus,
                Status = bill.Status,
                WaiterRequested = bill.WaiterRequested,
                ValueAmount = bill.Orders.Sum(_ => _.Quantity * _.Item.Value),
                Orders = bill.Orders.Where(_ => _.Status == Status.Active).Select(_ => (OrderModelResponse)_).ToList(),
                Users = bill.BillUsers.Where(_ => _.Status == Status.Active).Select(_ => (UserModelResponse)_.User).ToList(),
                PendingUsers = bill.BillUsers.Where(_ => _.Status == Status.None).Select(_ => (UserModelResponse)_.User).ToList()
            };
        }
    }
}
