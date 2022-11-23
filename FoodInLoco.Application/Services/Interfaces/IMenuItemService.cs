using DotNetCore.Objects;
using DotNetCore.Results;
using FoodInLoco.Application.Data.Models;

namespace FoodInLoco.Application.Services.Interfaces
{
    public interface IMenuItemService
    {
        Task<IResult<Guid>> AddAsync(MenuItemModel model);

        Task<IResult> DeleteAsync(Guid id);

        Task<MenuItemModel> GetAsync(Guid id);
        
        Task<Grid<MenuItemModel>> GridAsync(GridParameters parameters);

        Task<IEnumerable<MenuItemModel>> ListAsync();

        Task<IEnumerable<MenuItemModel>> ListByMenuAsync(Guid id);

        Task<IResult> UpdateAsync(MenuItemModel model);

        Task<IResult> InactivateAsync(Guid id);

        Task<IResult> ActivateAsync(Guid id);
    }
}
