using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Models;

namespace FoodInLoco.Application.Repositories.Interfaces
{
    public interface IAttractionRepository : IRepository<Attraction>
    {
        Task<AttractionModelResponse?> GetModelByIdAsync(Guid id);

        Task<IEnumerable<AttractionModelResponse>> ListModelAsync();

        Task UpdateStatusAsync(Attraction obj);
    }
}
