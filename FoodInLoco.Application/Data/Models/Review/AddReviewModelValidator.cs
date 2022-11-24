namespace FoodInLoco.Application.Data.Models
{
    public sealed class AddReviewModelValidator : ReviewModelValidator
    {
        public AddReviewModelValidator()
        {
            Restaurant(); Reservation(); User(); Name(); Description(); Rate();
        }
    }
}
