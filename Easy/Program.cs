using Easy;

Week week = new Week();


var iterator = week.GetEnumerator();

while (iterator.MoveNext())
{
    System.Console.WriteLine(iterator.Current);
}


