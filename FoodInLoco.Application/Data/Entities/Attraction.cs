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
            decimal coverTax
        )
        {
            RestaurantId = restaurantId;
            NameDescription = nameDescription;
            Photo = photo;
            Date = date;
            CoverTax = coverTax;
        }

        public Attraction(Guid id) => Id = id;

        public Guid RestaurantId { get; private set; }

        public NameDescription NameDescription { get; private set; }

        public string Photo { get; private set; }

        public DateTime Date { get; private set; }

        public decimal CoverTax { get; private set; }

        public Status Status { get; private set; }

        public Restaurant Restaurant { get; private set; }

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

        public void Update(string name, string description, string photo, DateTime date, decimal coverTax)
        {
            NameDescription = new NameDescription(name, description);
            Photo = photo;
            Date = date;
            CoverTax = coverTax;
        }
    }
}
