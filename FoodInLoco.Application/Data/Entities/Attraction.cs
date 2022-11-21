using FoodInLoco.Application.Data.ValueObjects;
using FoodInLoco.Application.Enums;

namespace FoodInLoco.Application.Data.Entities
{
    public class Attraction : Entity<Guid>
    {
        public Attraction
        (
            Guid restaurantId,
            NameDescription nameDescription,
            string photo,
            DateTime date,
            double coverTax
        )
        {
            RestaurantId = restaurantId;
            NameDescription = nameDescription;
            Photo = photo;
            Date = date;
            CoverTax = coverTax;
            CreatedAt = DateTime.UtcNow;
            Activate();
        }

        public Attraction(Guid id) => Id = id;

        public Guid RestaurantId { get; private set; }

        public NameDescription NameDescription { get; private set; }

        public string? Photo { get; private set; }

        public DateTime Date { get; private set; }

        public double CoverTax { get; private set; }

        public Status Status { get; private set; }

        public Restaurant Restaurant { get; private set; }

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

        public bool IsActive()
        {
            return Status == Status.Active;
        }

        public void Update(string name, string description, string photo, DateTime date, double coverTax)
        {
            NameDescription = new NameDescription(name, description);
            Photo = photo;
            Date = date;
            CoverTax = coverTax;
            LastUpdatedAt = DateTime.UtcNow;
        }
    }
}
