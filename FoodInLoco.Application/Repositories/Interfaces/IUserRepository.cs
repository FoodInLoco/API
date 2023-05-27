using DotNetCore.Objects;
using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Data.Entities;

namespace FoodInLoco.Application.Repositories.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        Task<UserModelResponse?> GetModelByIdAsync(Guid id);

        Task<UserModelResponse?> GetModelByIdWithRelationsAsync(Guid id);

        Task<UserModelResponse?> GetModelByEmailAsync(string email);

        Task<Grid<UserModelResponse>> GridAsync(GridParameters parameters);

        Task<IEnumerable<UserModelResponse>> ListModelAsync();

        Task UpdateStatusAsync(User obj);

        Task<bool> AnyByEmailAsync(string email);

        Task<User?> GetByEmailAsync(string email);
    }
}
