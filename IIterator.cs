namespace Iterator_Design_Pattern
{
    public interface IIterator<T>
    {
        bool MoveNext();
        T Current();
        int Key();
        void Reset();
    }
}