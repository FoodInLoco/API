namespace FoodInLoco.Application.Data.Models
{
    public sealed class UpdateMenuModelValidator : MenuModelValidator
    {
        public UpdateMenuModelValidator()
        {
            Id(); Restaurant(); Name(); Description(); InitialDate(); HappyHour();
        }
    }
}
