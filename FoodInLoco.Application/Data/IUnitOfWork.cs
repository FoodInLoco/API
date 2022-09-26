namespace FoodInLoco.Application.Data
{
    public interface IUnitOfWork
    {
        Task<int> SaveChangesAsync();
    }
}
