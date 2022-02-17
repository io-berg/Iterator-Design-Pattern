using System.Collections;

namespace Textbook
{
    public interface IWeekIterator
    {
        string Current { get; }

        bool MoveNext();
    }
}