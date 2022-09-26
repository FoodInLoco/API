using FoodInLoco.Application.Data.Entities;

namespace FoodInLoco.Application.Data.Repositories.Interfaces
{
    public interface IAuthRepository : IRepository<Auth>
    {
        Task<bool> AnyByLoginAsync(string login);

        Task<Auth> GetByLoginAsync(string login);
    }
}
