namespace FoodInLoco.Application.Data.Models
{
    public sealed class UpdateUserModelValidator : UserModelValidator
    {
        public UpdateUserModelValidator()
        {
            Id(); FirstName(); LastName(); Email(); DDD(); PhoneNumber();
        }
    }
}
