using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.ValueObjects;
using FoodInLoco.Application.Factories.Interfaces;

namespace FoodInLoco.Application.Factories
{
    public sealed class UserFactory : IUserFactory
    {
        public User Create(UserModel model, Auth auth)
        {
            return new User
            (
                new Name(model.FirstName, model.LastName),
                new Email(model.Email),
                new Phone(model.DDD, model.PhoneNumber),
                auth
            );
        }
    }
}
