using FoodInLoco.Application.Data.Enums;
using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Data.ValueObjects;

namespace FoodInLoco.Application.Data.Entities
{
    public class Restaurant : Entity<long>
    {
        public Restaurant
        (
            Company company,
            Email email,
            Phone phone,
            Address address
        )
        {
            Company = company;
            Email = email;
            CellPhone = phone;
            Address = address;
            Activate();
        }

        public Restaurant(long id) => Id = id;

        public Company Company { get; private set; }

        public Email Email { get; private set; }

        public Phone CellPhone { get; private set; }

        public Address Address { get; private set; }

        public Status Status { get; private set; }

        public ICollection<Menu> Menus { get; private set; }

        public void Activate()
        {
            Status = Status.Active;
        }

        public void Inactivate()
        {
            Status = Status.Inactive;
        }

        public void Update(string companyName, string tradingName, string email, string ddd, string phoneNumber, 
            string state, string city, string zipCode, string street, long addressNumber, string complement)
        {
            Company = new Company(companyName, tradingName);
            Email = new Email(email);
            CellPhone = new Phone(ddd, phoneNumber);
            Address = new Address(state, city, zipCode, street, addressNumber, complement);
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
                Complement = restaurant.Address.Complement
            };
        }
    }
}
