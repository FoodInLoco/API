namespace FoodInLoco.Application.Data.Models
{
    public class RestaurantModel
    {
        public long Id { get; set; }

        public string CompanyName { get; set; }

        public string TradingName { get; set; }

        public string Email { get; set; }

        public string DDD { get; set; }

        public string PhoneNumber { get; set; }

        public string State { get; set; }

        public string City { get; set; }

        public string ZipCode { get; set; }

        public string Street { get; set; }

        public long Number { get; set; }

        public string Complement { get; set; }

        public AuthModel? Auth { get; set; }
    }
}
