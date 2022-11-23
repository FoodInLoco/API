using DotNetCore.Objects;
using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Models;

namespace FoodInLoco.Application.Repositories.Interfaces
{
    public interface IMenuItemRepository : IRepository<MenuItem>
    {
        Task<MenuItemModel> GetModelByIdAsync(Guid id);

        Task<Grid<MenuItemModel>> GridAsync(GridParameters parameters);

        Task<IEnumerable<MenuItemModel>> ListModelAsync();

        Task<IEnumerable<MenuItemModel>> ListModelByMenuAsync(Guid id);

        Task UpdateStatusAsync(MenuItem obj);
    }
}
