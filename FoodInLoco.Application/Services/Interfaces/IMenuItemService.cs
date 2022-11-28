using DotNetCore.Objects;
using DotNetCore.Results;
using FoodInLoco.Application.Data.Models;

namespace FoodInLoco.Application.Services.Interfaces
{
    public interface IMenuItemService
    {
        Task<IResult<Guid>> AddAsync(MenuItemModelRequest model);

        Task<IResult> DeleteAsync(Guid id);

        Task<MenuItemModelResponse?> GetAsync(Guid id);
        
        Task<Grid<MenuItemModelResponse>> GridAsync(GridParameters parameters);

        Task<IEnumerable<MenuItemModelResponse>> ListAsync();

        Task<IEnumerable<MenuItemModelResponse>> ListByMenuAsync(Guid menuId);

        Task<IResult> UpdateAsync(MenuItemModelRequest model);

        Task<IResult> InactivateAsync(Guid id);

        Task<IResult> ActivateAsync(Guid id);
    }
}
