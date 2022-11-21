namespace FoodInLoco.Application.Data.ValueObjects
{
    public sealed record HappyHour(bool Value, TimeOnly? StartAt, TimeOnly? EndAt);
}
