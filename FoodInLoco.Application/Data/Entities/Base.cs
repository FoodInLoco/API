namespace FoodInLoco.Application.Data.Entities
{
    public abstract class Base<T> : IEquatable<Base<T>>
    {
        public static bool operator !=(Base<T> a, Base<T> b)
        {
            return !(a == b);
        }

        public static bool operator ==(Base<T> a, Base<T> b)
        {
            if ((object)a == null && (object)b == null)
            {
                return true;
            }

            if ((object)a == null || (object)b == null)
            {
                return false;
            }

            return a.Equals(b);
        }

        public sealed override bool Equals(object obj)
        {
            return Equals(obj as Base<T>);
        }

        public bool Equals(Base<T> other)
        {
            if ((object)other == null)
            {
                return false;
            }

            if ((object)this == other)
            {
                return true;
            }

            if (GetType() == other.GetType())
            {
                return Equals().SequenceEqual(other.Equals());
            }

            return false;
        }

        public override int GetHashCode()
        {
            return Equals().Aggregate(0, (int a, object b) => a * 97 + b.GetHashCode());
        }

        protected abstract IEnumerable<object> Equals();
    }
}
