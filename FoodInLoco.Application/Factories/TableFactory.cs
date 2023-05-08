using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Factories.Interfaces;

namespace FoodInLoco.Application.Factories
{
    public sealed class TableFactory : ITableFactory
    {
        public Table Create(TableModelRequest model)
        {
            return new Table
            (
                model.RestaurantId,
                model.Number
            );
        }
    }
}
