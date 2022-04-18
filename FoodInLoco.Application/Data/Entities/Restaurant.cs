using DotNetCore.Domain;
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
            Auth auth
        )
        {
            Company = company;
            Email = email;
            CellPhone = phone;
            Auth = auth;
            Activate();
        }

        public Restaurant(long id) => Id = id;

        public Company Company { get; private set; }

        public Email Email { get; private set; }

        public Phone CellPhone { get; private set; }

        public Status Status { get; private set; }

        public Auth Auth { get; private set; }

        public void Activate()
        {
            Status = Status.Active;
        }

        public void Inactivate()
        {
            Status = Status.Inactive;
        }

        public void Update(string companyName, string tradingName, string email, string ddd, string number)
        {
            Company = new Company(companyName, tradingName);
            Email = new Email(email);
            CellPhone = new Phone(ddd, number);
        }
    }
}
