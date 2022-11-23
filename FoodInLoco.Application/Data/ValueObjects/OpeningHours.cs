namespace FoodInLoco.Application.Data.ValueObjects
{
    public sealed record OpeningHours(DayOfWeek DayOfWeek, TimeOnly From, TimeOnly To);
}
