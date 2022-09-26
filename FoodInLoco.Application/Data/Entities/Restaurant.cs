using FoodInLoco.Application.Data.Enums;
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
            Address address,
            Auth auth
        )
        {
            Company = company;
            Email = email;
            CellPhone = phone;
            Address = address;
            Auth = auth;
            Activate();
        }

        public Restaurant(long id) => Id = id;

        public Company Company { get; private set; }

        public Email Email { get; private set; }

        public Phone CellPhone { get; private set; }

        public Address Address { get; private set; }

        public Status Status { get; private set; }

        public Auth Auth { get; private set; }

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
    }
}
