using FoodInLoco.Application.Data.ValueObjects;
using FoodInLoco.Application.Enums;

namespace FoodInLoco.Application.Data.Entities
{
    public class MenuItem : Entity<Guid>
    {
        public MenuItem
        (
            Guid menuId,
            NameDescription nameDescription,
            string photo,
            int quantity,
            double value
        )
        {
            MenuId = menuId;
            NameDescription = nameDescription;
            Photo = photo;
            Quantity = quantity;
            Value = value;
            CreatedAt = DateTime.UtcNow;
            Activate();
        }

        public MenuItem(Guid id) => Id = id;

        public Guid MenuId { get; private set; }

        public NameDescription NameDescription { get; private set; }

        public string Photo { get; private set; }

        public int Quantity { get; private set; }

        public double Value { get; private set; }

        public Status Status { get; private set; }

        public Menu Menu { get; private set; }

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

        public void Update(string name, string description, string photo, int quantity, double value)
        {
            NameDescription = new NameDescription(name, description);
            Photo = photo;
            Quantity = quantity;
            Value = value;
            LastUpdatedAt = DateTime.UtcNow;
        }
    }
}
