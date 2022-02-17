namespace Textbook
{
    public class WeekIterator : IWeekIterator
    {
        private readonly string[] weeks;
        private int position;


        public WeekIterator(string[] weeks)
        {
            this.weeks = weeks;
            this.position = -1;
        }

        public string Current => weeks[position];

        public bool MoveNext()
        {
            if (++position == weeks.Length) return false;
            return true;
        }
    }
}