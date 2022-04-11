using FoodInLoco.Application.Contracts.Models;
using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Enums;
using FoodInLoco.Application.Services.Interfaces;

namespace FoodInLoco.Application.Services
{
    public sealed class AuthFactory : IAuthFactory
    {
        public Auth Create(AuthModel model)
        {
            return new Auth(model.Login, model.Password, (Roles)model.Roles);
        }
    }
}
