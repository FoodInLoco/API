using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Data.ValueObjects;
using FoodInLoco.Application.Enums;

namespace FoodInLoco.Application.Data.Entities
{
    public class Restaurant : Entity<Guid>
    {
        public Restaurant
        (
            Company company,
            Email email,
            Phone phone,
            Address address,
            bool kids,
            string? photo
        )
        {
            Company = company;
            Email = email;
            CellPhone = phone;
            Address = address;
            Kids = kids;
            Photo = photo;
            CreatedAt = DateTime.UtcNow;
            Activate();
        }

        public Restaurant(Guid id) => Id = id;

        public Guid UserId { get; private set; }

        public Company Company { get; private set; }

        public Email Email { get; private set; }

        public Phone CellPhone { get; private set; }

        public Address Address { get; private set; }

        public bool Kids { get; private set; }

        public string? Photo { get; private set; }

        public Status Status { get; private set; }

        public User? User { get; private set; }

        public ICollection<Menu> Menus { get; private set; }

        public ICollection<Attraction> Attractions { get; private set; }

        public ICollection<Reservation> Reservations { get; private set; }

        public ICollection<Review> Reviews { get; private set; }

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

        public void Update(string companyName, string tradingName, string email, string ddd, string phoneNumber, 
            string state, string city, string zipCode, string street, long? addressNumber, string? complement, bool kids, string? photo)
        {
            Company = new Company(companyName, tradingName);
            Email = new Email(email);
            CellPhone = new Phone(ddd, phoneNumber);
            Address = new Address(state, city, zipCode, street, addressNumber, complement);
            Kids = kids;
            Photo = photo;
            LastUpdatedAt = DateTime.UtcNow;
        }

        public static implicit operator RestaurantModel(Restaurant restaurant)
        {
            return new RestaurantModel()
            {
                Id = restaurant.Id,
                CompanyName = restaurant.Company.CompanyName,
                TradingName = restaurant.Company.TradingName,
                Email = restaurant.Email.Value,
                DDD = restaurant.CellPhone.DDD,
                PhoneNumber = restaurant.CellPhone.PhoneNumber,
                State = restaurant.Address.State,
                City = restaurant.Address.City,
                ZipCode = restaurant.Address.ZipCode,
                Street = restaurant.Address.Street,
                Number = restaurant.Address.Number,
                Complement = restaurant.Address.Complement,
                Kids = restaurant.Kids,
                Photo = restaurant.Photo
            };
        }
    }
}
