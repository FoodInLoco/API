using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Models;

namespace FoodInLoco.Application.Repositories.Interfaces
{
    public interface IMenuRepository : IRepository<Menu>
    {
        Task<MenuModel> GetModelByIdAsync(Guid id);

        Task<IEnumerable<MenuModel>> ListModelAsync();

        Task UpdateStatusAsync(Menu obj);
    }
}
