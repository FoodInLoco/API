namespace FoodInLoco.Application.Data.Repositories.Interfaces
{
    public interface IRepository<T> : ICommandRepository<T>, IQueryRepository<T> where T : class
    {
    }
}
