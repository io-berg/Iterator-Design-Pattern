using System.Collections;

namespace Textbook
{
    public class Week : IEnumerable
    {
        private string[] week = new string[]{
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"
            };


        public IEnumerator GetEnumerator() => new WeekIterator(week);
    }
}