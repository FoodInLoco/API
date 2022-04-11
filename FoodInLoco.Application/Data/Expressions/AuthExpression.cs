using FoodInLoco.Application.Data.Entities;
using System.Linq.Expressions;

namespace FoodInLoco.Application.Data.Expressions
{
    public static class AuthExpression
    {
        public static Expression<Func<Auth, bool>> Login(string login)
        {
            return auth => auth.Login == login;
        }
    }
}
