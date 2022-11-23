using FoodInLoco.Application.Data.ValueObjects;
using FoodInLoco.Application.Enums;

namespace FoodInLoco.Application.Data.Entities
{
    public class Reservation : Entity<Guid>
    {
        public Reservation
        (
            Guid restaurantId,
            Guid userId,
            string description,
            short seatQuantity,
            DateTime date
        )
        {
            RestaurantId = restaurantId;
            UserId = userId;
            Description = description;
            SeatQuantity = seatQuantity;
            Date = date;
            CreatedAt = DateTime.UtcNow;
            Activate();
        }

        public Reservation(Guid id) => Id = id;

        public Guid RestaurantId { get; private set; }

        public Guid UserId { get; private set; }

        public string Description { get; private set; }

        public short SeatQuantity { get; private set; }

        public DateTime Date { get; private set; }

        public Status Status { get; private set; }

        public Status Confirmation { get; private set; }

        public Review Review { get; set; }

        public Restaurant Restaurant { get; private set; }

        public User User { get; private set; }

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
            Confirmation = Status.Active;
            LastUpdatedAt = DateTime.UtcNow;
        }

        public void Disconfirm()
        {
            Confirmation = Status.Inactive;
            LastUpdatedAt = DateTime.UtcNow;
        }

        public bool IsActive() => Status == Status.Active && Confirmation == Status.Active;

        public void Update(string description, short seatQuantity, DateTime date)
        {
            Description = description;
            SeatQuantity = seatQuantity;
            Date = date;
            Confirmation = Status.None;
            LastUpdatedAt = DateTime.UtcNow;
        }
    }
}
