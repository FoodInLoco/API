using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Enums;

namespace FoodInLoco.Application.Data.Entities
{
    public class Table : Entity<Guid>
    {
        public Table
        (
            Guid restaurantId, 
            int number
        )
        {
            RestaurantId = restaurantId;
            Number = number;
            CreatedAt = DateTime.UtcNow;
            Activate();
        }

        public Table(Guid id) => Id = id;

        public int Number { get; private set; }

        public Guid RestaurantId { get; private set; }

        public Status Status { get; private set; }

        public Restaurant Restaurant { get; private set; }

        public ICollection<Bill> Bills { get; private set; }

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

        public bool IsOccupied() => Bills.Any(_ => _.BillingStatus == BillingStatus.Pending);

        public void Update(int number)
        {
            Number = number;
            LastUpdatedAt = DateTime.UtcNow;
        }

        public static implicit operator TableModelResponse(Table table)
        {
            if (table is null)
                return null;

            return new TableModelResponse()
            {
                Id = table.Id,
                CreatedAt = table.CreatedAt,
                LastUpdatedAt = table.LastUpdatedAt,
                RestaurantId = table.RestaurantId,
                Number = table.Number,
                Status = table.Status,
                Occupied = table.IsOccupied(),
                RestaurantName = table.Restaurant?.Company.CompanyName
            };
        }
    }
}
