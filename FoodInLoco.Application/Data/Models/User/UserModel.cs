using FoodInLoco.Application.Enums;

namespace FoodInLoco.Application.Data.Models
{
    public sealed record UserModel
    {
        public Guid Id { get; init; }

        public DateOnly CreatedAt { get; init; }

        public DateOnly? LastUpdatedAt { get; init; }

        public string FirstName { get; init; }

        public string LastName { get; init; }

        public string Email { get; init; }

        public string DDD { get; init; }

        public string PhoneNumber { get; init; }

        public string Password { get; set; }
        
        public Roles Roles { get; init; }

        public string Photo { get; set; }
    }
}
