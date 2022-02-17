using System.Collections;

namespace Easy
{
    public class Week : IEnumerable
    {
        private string[] _week = new string[]
        {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"
        };

        public string this[int index]
        {
            get => _week[index];
            set => _week[index] = value;
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var day in _week)
            {
                yield return day;
            }
        }
    }
}