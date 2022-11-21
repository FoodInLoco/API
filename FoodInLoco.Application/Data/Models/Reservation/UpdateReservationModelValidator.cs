namespace FoodInLoco.Application.Data.Models
{
    public sealed class UpdateReservationModelValidator : ReservationModelValidator
    {
        public UpdateReservationModelValidator()
        {
            Id(); Restaurant(); User(); Description(); SeatQuantity(); Date();
        }
    }
}
