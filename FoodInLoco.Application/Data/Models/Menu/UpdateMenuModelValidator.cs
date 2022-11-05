namespace FoodInLoco.Application.Data.Models
{
    public sealed class UpdateMenuModelValidator : MenuModelValidator
    {
        public UpdateMenuModelValidator()
        {
            Id(); Restaurant(); Name(); Description(); Photo(); InitialDate(); 
            ExpirationDate(); HappyHour(); StartAt(); EndAt(); Status();
        }
    }
}
