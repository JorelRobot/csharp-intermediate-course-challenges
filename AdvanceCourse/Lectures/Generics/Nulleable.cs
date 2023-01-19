
namespace CSharpIntermediateChallenges.AdvanceCourse.Lectures.Generics
{
    public class Nulleable<T> where T : struct
    {
        private object _value;

        public Nulleable() {
            
        }

        public Nulleable(T value)
        {
            _value = value;
        }

        public bool HasValue
        {
            get { return _value != null; }
        }

        public T GetValueOrDefault()
        {
            if (HasValue)
                return (T)_value;

            return default(T);
        }
    }
}