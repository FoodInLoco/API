namespace FoodInLoco.Application.Data.Models
{
    public sealed class AddMenuItemModelValidator : MenuItemModelValidator
    {
        public AddMenuItemModelValidator()
        {
            Menu(); Name(); Description(); Photo(); Quantity(); Value();
        }
    }
}
