namespace FoodInLoco.Application.Data.Entities
{
    public abstract class Entity<TId> : Base<Entity<TId>>
    {
        public TId Id { get; protected set; }

        public DateOnly CreatedAt { get; protected set; }

        public DateOnly? LastUpdatedAt { get; protected set; }

        protected sealed override IEnumerable<object> Equals()
        {
            yield return Id;
        }
    }
}
