using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Helpers;
using Newtonsoft.Json;
using System.Linq.Expressions;

namespace FoodInLoco.Application.Data.Expressions
{
    public static class TableExpression
    {
        public static Expression<Func<Table, TableModelResponse>> Model => _ => new TableModelResponse
        {
            Id = _.Id,
            CreatedAt = _.CreatedAt,
            LastUpdatedAt = _.LastUpdatedAt,
            RestaurantId = _.RestaurantId,
            QrCode = QRCodeService.GenerateQRCodeBytes(JsonConvert.SerializeObject(new { tableId = _.Id })),
            Number = _.Number,
            Status = _.Status,
            Occupied = _.IsOccupied(),
            RestaurantName = _.Restaurant.Company.CompanyName
        };

        public static Expression<Func<Table, bool>> IsOccupied => _ => _.IsOccupied();

        public static Expression<Func<Table, bool>> Id(Guid id)
        {
            return _ => _.Id == id;
        }

        public static Expression<Func<Table, bool>> RestaurantId(Guid id)
        {
            return _ => _.RestaurantId == id;
        }
    }
}
