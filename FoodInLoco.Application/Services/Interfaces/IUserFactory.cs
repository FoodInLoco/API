using FoodInLoco.Application.Contracts.Models;
using FoodInLoco.Application.Data.Entities;

namespace FoodInLoco.Application.Services.Interfaces
{
    public interface IUserFactory
    {
        User Create(UserModel model, Auth auth);
    }
}
