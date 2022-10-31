using FoodInLoco.Application.Data.ValueObjects;

namespace FoodInLoco.Application.Data.Entities
{
    public class Menu : Entity<long>
    {
        public Menu
        (
            long restaurantId,
            NameDescription nameDescription,
            DateTime initialDate,
            DateTime expirationDate,
            HappyHour happyHour
        )
        {
            RestaurantId = restaurantId;
            NameDescription = nameDescription;
            InitialDate = initialDate;
            ExpirationDate = expirationDate;
            HappyHour = happyHour;
        }

        public Menu(long id) => Id = id;

        public long RestaurantId { get; private set; }

        public NameDescription NameDescription { get; private set; }

        public DateTime InitialDate { get; private set; }
        
        public DateTime? ExpirationDate { get; private set; }
        
        public HappyHour HappyHour { get; private set; }

        public Restaurant Restaurant { get; private set; }

        public ICollection<MenuItem> Items { get; private set; }

        public bool IsActive()
        {
            return !(ExpirationDate?.CompareTo(DateTime.Now) < 0);
        }

        public void Update(string name, string description, DateTime? expirationDate, bool happyHour, int? startAt, int? endAt)
        {
            NameDescription = new NameDescription(name, description);
            ExpirationDate = expirationDate;
            HappyHour = new HappyHour(happyHour, startAt, endAt);
        }
    }
}
