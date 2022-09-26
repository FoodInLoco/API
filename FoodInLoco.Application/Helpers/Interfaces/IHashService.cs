namespace FoodInLoco.Application.Helpers.Interfaces
{
    public interface IHashService
    {
        string Create(string value, string salt);
    }
}
