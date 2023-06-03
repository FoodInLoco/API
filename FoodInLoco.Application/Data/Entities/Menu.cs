using FoodInLoco.Application.Data.Models;
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
            string? photo,
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
            CreatedAt = DateTime.UtcNow;
            Activate();
        }

        public Menu(Guid id) => Id = id;

        public Guid RestaurantId { get; private set; }

        public NameDescription NameDescription { get; private set; }

        public string? Photo { get; private set; }

        public DateTime InitialDate { get; private set; }
        
        public DateTime? ExpirationDate { get; private set; }
        
        public HappyHour HappyHour { get; private set; }

        public Status Status { get; private set; }

        public Restaurant Restaurant { get; private set; }

        public ICollection<MenuItem> Items { get; private set; }

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

        public bool IsActive() => Status == Status.Active && !(ExpirationDate?.CompareTo(DateTime.Now) <= 0);

        public void Update(string name, string description, DateTime? expirationDate, bool happyHour, TimeOnly? startAt, TimeOnly? endAt)
        {
            NameDescription = new NameDescription(name, description);
            ExpirationDate = expirationDate;
            HappyHour = new HappyHour(happyHour, startAt, endAt);
            LastUpdatedAt = DateTime.UtcNow;
        }

        public static implicit operator MenuModelResponse(Menu menu)
        {
            if (menu is null)
                return null;

            return new MenuModelResponse()
            {
                Id = menu.Id,
                CreatedAt = menu.CreatedAt,
                LastUpdatedAt = menu.LastUpdatedAt,
                RestaurantId = menu.RestaurantId,
                RestaurantName = menu.Restaurant?.Company.CompanyName,
                Name = menu.NameDescription.Name,
                Description = menu.NameDescription.Description,
                Photo = menu.Photo,
                InitialDate = menu.InitialDate,
                ExpirationDate = menu.ExpirationDate,
                HappyHour = menu.HappyHour.Value,
                StartAt = menu.HappyHour.StartAt.ToString(),
                EndAt = menu.HappyHour.EndAt.ToString(),
                Status = menu.Status,
                Items = menu.Items?.Select(_ => (MenuItemModelResponse)_).ToList()
            };
        }
    }
}
