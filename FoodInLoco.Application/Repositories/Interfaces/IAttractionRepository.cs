using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Models;

namespace FoodInLoco.Application.Repositories.Interfaces
{
    public interface IAttractionRepository : IRepository<Attraction>
    {
        Task<AttractionModel> GetModelByIdAsync(Guid id);

        Task<IEnumerable<AttractionModel>> ListModelAsync();

        Task UpdateStatusAsync(Attraction obj);
    }
}
