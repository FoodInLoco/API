using FoodInLoco.Application.Data.Enums;
using FoodInLoco.Application.Data.ValueObjects;

namespace FoodInLoco.Application.Data.Entities
{
    public class Attraction : Entity<long>
    {
        public Attraction
        (
            long restaurantId,
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

        public Attraction(long id) => Id = id;

        public long RestaurantId { get; private set; }

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
