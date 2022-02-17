using System.Collections;

namespace Textbook
{
    public class WeekIterator : IEnumerator
    {
        private readonly string[] weeks;
        private int position;


        public WeekIterator(string[] weeks)
        {
            this.weeks = weeks;
            this.position = -1;
        }

        public object Current => weeks[position];

        public bool MoveNext()
        {
            if (++position == weeks.Length) return false;
            return true;
        }

        public void Reset()
        {
            this.position = -1;
        }
    }
}