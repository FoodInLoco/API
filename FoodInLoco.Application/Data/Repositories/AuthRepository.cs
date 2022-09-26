using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Expressions;
using FoodInLoco.Application.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FoodInLoco.Application.Data.Repositories
{
    public sealed class AuthRepository : EFRepository<Auth>, IAuthRepository
    {
        public AuthRepository(Context context) : base(context) { }

        public Task<bool> AnyByLoginAsync(string login)
        {
            return Queryable.AnyAsync(AuthExpression.Login(login));
        }

        public Task<Auth> GetByLoginAsync(string login)
        {
            return Queryable.SingleOrDefaultAsync(AuthExpression.Login(login));
        }
    }
}
