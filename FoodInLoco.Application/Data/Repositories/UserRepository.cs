using DotNetCore.Objects;
using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Expressions;
using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FoodInLoco.Application.Data.Repositories
{
    public sealed class UserRepository : EFRepository<User>, IUserRepository
    {
        private readonly Context _dbContext;

        public UserRepository(Context dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<long> GetAuthIdByUserIdAsync(long id)
        {
            return Queryable.Where(UserExpression.Id(id)).Select(UserExpression.AuthId).SingleOrDefaultAsync();
        }

        public Task<UserModel> GetModelByIdAsync(long id)
        {
            return Queryable.Where(UserExpression.Id(id)).Select(UserExpression.Model).SingleOrDefaultAsync();
        }

        public Task<Grid<UserModel>> GridAsync(GridParameters parameters)
        {
            return Queryable.Select(UserExpression.Model).GridAsync(parameters);
        }

        public async Task<IEnumerable<UserModel>> ListModelAsync()
        {
            return await Queryable.Select(UserExpression.Model).ToListAsync();
        }

        public Task UpdateStatusAsync(User user)
        {
            return UpdatePartialAsync(new { user.Id, user.Status });
        }
    }
}
