using System.Collections;

namespace Iterator_Design_Pattern
{
    public abstract class IteratorAggregate
    {
        public abstract IEnumerator GetEnumerator();
    }
}