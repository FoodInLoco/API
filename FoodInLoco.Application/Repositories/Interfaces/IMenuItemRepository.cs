using DotNetCore.Objects;
using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Models;

namespace FoodInLoco.Application.Repositories.Interfaces
{
    public interface IMenuItemRepository : IRepository<MenuItem>
    {
        Task<MenuItemModelResponse?> GetModelByIdAsync(Guid id);

        Task<Grid<MenuItemModelResponse>> GridAsync(GridParameters parameters);

        Task<IEnumerable<MenuItemModelResponse>> ListModelAsync();

        Task<IEnumerable<MenuItemModelResponse>> ListModelByMenuAsync(Guid menuId);

        Task UpdateStatusAsync(MenuItem obj);
    }
}
