using Textbook;

var week = new Week();

var iterator = week.GetEnumerator();

List<string> myList = new();

myList.GetEnumerator();

while (iterator.MoveNext())
{
    Console.WriteLine(iterator.Current);
}

foreach (var day in week)
{
    Console.WriteLine(day);
}

