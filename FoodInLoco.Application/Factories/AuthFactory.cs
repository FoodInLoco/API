using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Enums;
using FoodInLoco.Application.Factories.Interfaces;

namespace FoodInLoco.Application.Factories
{
    public sealed class AuthFactory : IAuthFactory
    {
        public Auth Create(AuthModel model)
        {
            return new Auth(model.Login, model.Password, (Roles)model.Roles);
        }
    }
}
