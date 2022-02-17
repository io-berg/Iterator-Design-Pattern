namespace Textbook
{
    public class Week
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


        public IWeekIterator GetEnumerator()
        {
            return new WeekIterator(week);
        }
    }
}