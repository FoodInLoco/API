using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Data.ValueObjects;
using FoodInLoco.Application.Enums;

namespace FoodInLoco.Application.Data.Entities
{
    public class User : Entity<Guid>
    {
        public User
        (
            Name name,
            Email email,
            Phone phone,
            string? photo
        )
        {
            Name = name;
            Email = email;
            CellPhone = phone;
            Photo = photo;
            Salt = Guid.NewGuid().ToString();
            CreatedAt = DateTime.UtcNow;
            Activate();
        }

        public User(Guid id) => Id = id;

        public Name Name { get; private set; }

        public Email Email { get; private set; }

        public Phone CellPhone { get; private set; }

        public Status Status { get; private set; }

        public string Password { get; private set; }

        public string Salt { get; private set; }

        public string? Photo { get; private set; }

        public ICollection<Restaurant> Restaurants { get; private set; }

        public ICollection<Review> Reviews { get; private set; }

        public ICollection<Reservation> Reservations { get; private set; }

        public ICollection<BillUser> BillUsers { get; private set; }

        public ICollection<Order> Orders { get; private set; }

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

        public void Update(string firstName, string lastName, string email, string ddd, string number, string? photo)
        {
            Name = new Name(firstName, lastName);
            Email = new Email(email);
            CellPhone = new Phone(ddd, number);
            Photo = photo;
            LastUpdatedAt = DateTime.UtcNow;
        }

        public void UpdatePassword(string password)
        {
            Password = password;
            LastUpdatedAt = DateTime.UtcNow;
        }

        public static implicit operator UserModelResponse(User user)
        {
            if (user is null)
                return null;

            return new UserModelResponse()
            {
                Id = user.Id,
                CreatedAt = user.CreatedAt,
                LastUpdatedAt = user.LastUpdatedAt,
                FirstName = user.Name.FirstName,
                LastName = user.Name.LastName,
                Email = user.Email.Value,
                DDD = user.CellPhone.DDD,
                PhoneNumber = user.CellPhone.PhoneNumber,
                Photo = user.Photo,
                Restaurants = user.Restaurants?.Select(_ => (RestaurantModelResponse)_).ToList(),
                Reservations = user.Reservations?.Select(_ => (ReservationModelResponse)_).ToList()
            };
        }
    }
}
