using Textbook;

var week = new Week();

foreach (var day in week)
{
    Console.WriteLine(day);
}



System.Console.WriteLine(week.GetEnumerator().GetType());