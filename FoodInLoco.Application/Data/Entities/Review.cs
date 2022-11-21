using FoodInLoco.Application.Data.ValueObjects;
using FoodInLoco.Application.Enums;

namespace FoodInLoco.Application.Data.Entities
{
    public class Review : Entity<Guid>
    {
        public Review
        (
            long restaurantId,
            long reservationId,
            NameDescription nameDescription,
            Rate rate
        )
        {
            RestaurantId = restaurantId;
            ReservationId = reservationId;
            NameDescription = nameDescription;
            Rate = rate;
        }

        public Review(Guid id) => Id = id;

        public long RestaurantId { get; private set; }

        public long ReservationId { get; private set; }

        public NameDescription NameDescription { get; private set; }

        public Rate Rate { get; private set; }

        public Status Status { get; private set; }

        public Restaurant Restaurant { get; private set; }

        public Reservation Reservation { get; private set; }

        public void Activate()
        {
            Status = Status.Active;
        }

        public void Inactivate()
        {
            Status = Status.Inactive;
        }

        public bool IsActive()
        {
            return Status == Status.Active;
        }

        public void Update(string name, string description, Rate rate)
        {
            NameDescription = new NameDescription(name, description);
            Rate = rate;
        }
    }
}
