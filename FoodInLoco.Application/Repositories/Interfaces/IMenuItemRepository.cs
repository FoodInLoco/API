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

        Task UpdateStatusAsync(MenuItem obj);
    }
}
