namespace FoodInLoco.Application.Data.Models
{
    public sealed class UpdateMenuItemModelValidator : MenuItemModelValidator
    {
        public UpdateMenuItemModelValidator()
        {
            Id(); Menu(); Name(); Description(); Photo(); Quantity(); Value();
        }
    }
}
