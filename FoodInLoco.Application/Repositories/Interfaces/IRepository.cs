namespace FoodInLoco.Application.Repositories.Interfaces
{
    public interface IRepository<T> : ICommandRepository<T>, IQueryRepository<T> where T : class
    {
    }
}
