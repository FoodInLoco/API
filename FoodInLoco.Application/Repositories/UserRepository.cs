using DotNetCore.Objects;
using FoodInLoco.Application.Data;
using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Expressions;
using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FoodInLoco.Application.Repositories
{
    public sealed class UserRepository : EFRepository<User>, IUserRepository
    {
        public UserRepository(Context dbContext) : base(dbContext) { }

        public async Task<UserModelResponse?> GetModelByIdAsync(Guid id)
        {
            return await Queryable.Where(UserExpression.Id(id)).Select(UserExpression.Model).SingleOrDefaultAsync();
        }

        public async Task<UserModelResponse?> GetModelByIdWithRelationsAsync(Guid id)
        {
            return await Queryable.Where(UserExpression.Id(id))
                .Include(_ => _.Restaurants)
                .Include(_ => _.Reservations).ThenInclude(_ => _.Restaurant)
                .Select(UserExpression.Model).SingleOrDefaultAsync();
        }

        public async Task<UserModelResponse?> GetModelByEmailAsync(string email)
        {
            return await Queryable.Where(UserExpression.Email(email)).Select(UserExpression.Model).SingleOrDefaultAsync();
        }

        public async Task<Grid<UserModelResponse>> GridAsync(GridParameters parameters)
        {
            return await Queryable.Select(UserExpression.Model).GridAsync(parameters);
        }

        public async Task<IEnumerable<UserModelResponse>> ListModelAsync()
        {
            return await Queryable.Select(UserExpression.Model).ToListAsync();
        }

        public Task UpdateStatusAsync(User obj)
        {
            return UpdatePartialAsync(new { obj.Id, obj.Status, LastUpdatedAt = DateTime.UtcNow });
        }

        public async Task<bool> AnyByEmailAsync(string email)
        {
            return await Queryable.AnyAsync(UserExpression.Email(email));
        }

        public async Task<User?> GetByEmailAsync(string email)
        {
            return await Queryable.SingleOrDefaultAsync(UserExpression.Email(email));
        }

    }
}
