using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Data.ValueObjects;
using FoodInLoco.Application.Enums;

namespace FoodInLoco.Application.Data.Entities
{
    public class Review : Entity<Guid>
    {
        public Review
        (
            Guid restaurantId,
            Guid reservationId,
            Guid userId,
            NameDescription nameDescription,
            Rate rate
        )
        {
            RestaurantId = restaurantId;
            ReservationId = reservationId;
            UserId = userId;
            NameDescription = nameDescription;
            Rate = rate;
            CreatedAt = DateTime.UtcNow;
            Activate();
        }

        public Review(Guid id) => Id = id;

        public Guid RestaurantId { get; private set; }

        public Guid ReservationId { get; private set; }

        public Guid UserId { get; private set; }

        public NameDescription NameDescription { get; private set; }

        public Rate Rate { get; private set; }

        public Status Status { get; private set; }

        public Restaurant Restaurant { get; private set; }

        public Reservation Reservation { get; private set; }

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

        public bool IsActive() => Status == Status.Active;

        public void Update(string name, string description, Rate rate)
        {
            NameDescription = new NameDescription(name, description);
            Rate = rate;
            LastUpdatedAt = DateTime.UtcNow;
        }

        public static implicit operator ReviewModelResponse(Review review)
        {
            if (review is null)
                return null;

            return new ReviewModelResponse()
            {
                Id = review.Id,
                CreatedAt = review.CreatedAt,
                LastUpdatedAt = review.LastUpdatedAt,
                RestaurantId = review.RestaurantId,
                ReservationId = review.ReservationId,
                UserId = review.UserId,
                Name = review.NameDescription.Name,
                Description = review.NameDescription.Description,
                Rate = review.Rate,
                Status = review.Status,
                User = review.User
            };
        }
    }
}
