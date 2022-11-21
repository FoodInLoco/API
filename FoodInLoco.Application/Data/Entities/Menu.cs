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
            DateOnly initialDate,
            DateOnly? expirationDate,
            HappyHour happyHour
        )
        {
            RestaurantId = restaurantId;
            NameDescription = nameDescription;
            Photo = photo;
            InitialDate = initialDate;
            ExpirationDate = expirationDate;
            HappyHour = happyHour;
            CreatedAt = DateOnly.FromDateTime(DateTime.UtcNow);
            Activate();
        }

        public Menu(Guid id) => Id = id;

        public Guid RestaurantId { get; private set; }

        public NameDescription NameDescription { get; private set; }

        public string Photo { get; private set; }

        public DateOnly InitialDate { get; private set; }
        
        public DateOnly? ExpirationDate { get; private set; }
        
        public HappyHour HappyHour { get; private set; }

        public Status Status { get; private set; }

        public Restaurant Restaurant { get; private set; }

        public ICollection<MenuItem> Items { get; private set; }

        public void Activate()
        {
            Status = Status.Active;
            LastUpdatedAt = DateOnly.FromDateTime(DateTime.UtcNow);
        }

        public void Inactivate()
        {
            Status = Status.Inactive;
            LastUpdatedAt = DateOnly.FromDateTime(DateTime.UtcNow);
        }

        public bool IsActive()
        {
            return !(ExpirationDate?.CompareTo(DateTime.Now) < 0) && Status == Status.Active;
        }

        public void Update(string name, string description, DateOnly? expirationDate, bool happyHour, TimeOnly? startAt, TimeOnly? endAt)
        {
            NameDescription = new NameDescription(name, description);
            ExpirationDate = expirationDate;
            HappyHour = new HappyHour(happyHour, startAt, endAt);
            LastUpdatedAt = DateOnly.FromDateTime(DateTime.UtcNow);
        }
    }
}
