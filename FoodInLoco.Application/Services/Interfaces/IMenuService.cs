using DotNetCore.Results;
using FoodInLoco.Application.Data.Models;

namespace FoodInLoco.Application.Services.Interfaces
{
    public interface IMenuService
    {
        Task<IResult<Guid>> AddAsync(MenuModel model);

        Task<IResult> DeleteAsync(Guid id);

        Task<MenuModel> GetAsync(Guid id);
        
        Task<IEnumerable<MenuModel>> ListAsync();

        Task<IResult> UpdateAsync(MenuModel model);

        Task<IResult> InactivateAsync(Guid id);

        Task<IResult> ActivateAsync(Guid id);
    }
}
