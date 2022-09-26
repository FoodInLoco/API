using FoodInLoco.Application.Data.Enums;
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
            Auth auth
        )
        {
            Name = name;
            Email = email;
            CellPhone = phone;
            Auth = auth;
            Activate();
        }

        public User(long id) => Id = id;

        public Name Name { get; private set; }

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

        public void Update(string firstName, string lastName, string email, string ddd, string number)
        {
            Name = new Name(firstName, lastName);
            Email = new Email(email);
            CellPhone = new Phone(ddd, number);
        }
    }
}
