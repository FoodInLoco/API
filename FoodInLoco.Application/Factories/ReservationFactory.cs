using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Data.ValueObjects;
using FoodInLoco.Application.Enums;
using FoodInLoco.Application.Factories.Interfaces;

namespace FoodInLoco.Application.Factories
{
    public sealed class ReservationFactory : IReservationFactory
    {
        public Reservation Create(ReservationModelRequest model)
        {
            return new Reservation
            (
                model.RestaurantId,
                model.UserId,
                model.Description,
                model.SeatQuantity,
                model.Date
            );
        }
    }
}
