using FoodInLoco.Application.Data.ValueObjects;
using FoodInLoco.Application.Enums;

namespace FoodInLoco.Application.Data.Entities
{
    public class Menu : Entity<Guid>
    {
        public Menu
        (
            Guid restaurantId,
            NameDescription nameDescription,
            string photo,
            DateTime initialDate,
            DateTime? expirationDate,
            HappyHour happyHour
        )
        {
            RestaurantId = restaurantId;
            NameDescription = nameDescription;
            Photo = photo;
            InitialDate = initialDate;
            ExpirationDate = expirationDate;
            HappyHour = happyHour;
        }

        public Menu(Guid id) => Id = id;

        public Guid RestaurantId { get; private set; }

        public NameDescription NameDescription { get; private set; }

        public string Photo { get; private set; }

        public DateTime InitialDate { get; private set; }
        
        public DateTime? ExpirationDate { get; private set; }
        
        public HappyHour HappyHour { get; private set; }

        public Status Status { get; private set; }

        public Restaurant Restaurant { get; private set; }

        public ICollection<MenuItem> Items { get; private set; }

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
            return !(ExpirationDate?.CompareTo(DateTime.UtcNow) < 0) && Status == Status.Active;
        }

        public void Update(string name, string description, DateTime? expirationDate, bool happyHour, string? startAt, string? endAt)
        {
            NameDescription = new NameDescription(name, description);
            ExpirationDate = expirationDate;
            HappyHour = new HappyHour(happyHour, startAt, endAt);
        }
    }
}
