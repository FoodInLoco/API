using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Factories.Interfaces;

namespace FoodInLoco.Application.Factories
{
    public sealed class ReservationFactory : IReservationFactory
    {
        public Reservation Create(Guid userId, ReservationModelRequest model)
        {
            return new Reservation
            (
                model.RestaurantId,
                userId,
                model.Description,
                model.SeatQuantity,
                model.Date
            );
        }
    }
}
