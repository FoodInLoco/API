namespace FoodInLoco.Application.Contracts.Models
{
    public sealed class UpdateUserModelValidator : UserModelValidator
    {
        public UpdateUserModelValidator()
        {
            Id(); FirstName(); LastName(); Email(); DDD(); PhoneNumber();
        }
    }
}
