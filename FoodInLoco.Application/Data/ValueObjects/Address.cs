namespace FoodInLoco.Application.Data.ValueObjects
{
    public sealed record Address(string City, string State, string ZipCode, string Street, long? Number, string? Complement);
}
