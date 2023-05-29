namespace FoodInLoco.Application.Data.Models
{
    public sealed record TokenModel<T>(string Token, T Login);
}
