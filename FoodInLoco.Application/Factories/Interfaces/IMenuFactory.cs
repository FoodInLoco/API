using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Data.Entities;

namespace FoodInLoco.Application.Factories.Interfaces
{
    public interface IMenuFactory
    {
        Menu Create(MenuModelRequest model);
    }
}
