namespace FoodInLoco.Application.Contracts.Models
{
    public sealed class AddUserModelValidator : UserModelValidator
    {
        public AddUserModelValidator()
        {
            FirstName(); LastName(); Email(); DDD(); PhoneNumber(); Auth();
        }
    }
}
