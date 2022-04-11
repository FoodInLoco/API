namespace FoodInLoco.Application.Contracts.Models
{
    public sealed record AuthModel(string Login, string Password, int Roles);
}
