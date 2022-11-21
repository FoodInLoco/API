namespace FoodInLoco.Application.Data.Entities
{
    public abstract class Entity<TId> : Base<Entity<TId>>
    {
        public TId Id { get; protected set; }

        public DateTime InsertDate { get; protected set; }

        public DateTime UpdateDate { get; protected set; }

        protected sealed override IEnumerable<object> Equals()
        {
            yield return Id;
        }
    }
}
