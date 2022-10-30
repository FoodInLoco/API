using FoodInLoco.Application.Data.Enums;
using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Data.ValueObjects;

namespace FoodInLoco.Application.Data.Entities
{
    public class User : Entity<long>
    {
        public User
        (
            Name name,
            Email email,
            Phone phone,
            Roles roles
        )
        {
            Name = name;
            Email = email;
            CellPhone = phone;
            Roles = roles;
            Salt = Guid.NewGuid().ToString();
            Activate();
        }

        public User(long id) => Id = id;

        public Name Name { get; private set; }

        public Email Email { get; private set; }

        public Phone CellPhone { get; private set; }

        public Status Status { get; private set; }

        public Roles Roles { get; private set; }

        public string Password { get; private set; }

        public string Salt { get; private set; }

        public void Activate()
        {
            Status = Status.Active;
        }

        public void Inactivate()
        {
            Status = Status.Inactive;
        }

        public void Update(string firstName, string lastName, string email, string ddd, string number)
        {
            Name = new Name(firstName, lastName);
            Email = new Email(email);
            CellPhone = new Phone(ddd, number);
        }

        public void UpdatePassword(string password)
        {
            Password = password;
        }

        public static implicit operator UserModel(User user)
        {
            return new UserModel()
            {
                Id = user.Id,
                FirstName = user.Name.FirstName,
                LastName = user.Name.LastName,
                Email = user.Email.Value,
                DDD = user.CellPhone.DDD,
                PhoneNumber = user.CellPhone.PhoneNumber,
                Roles = user.Roles
            };
        }
    }
}
