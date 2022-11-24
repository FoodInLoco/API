namespace FoodInLoco.Application.Data.Models
{
    public sealed class UpdateReviewModelValidator : ReviewModelValidator
    {
        public UpdateReviewModelValidator()
        {
            Id(); Restaurant(); Reservation(); User(); Name(); Description(); Rate();
        }
    }
}
