using Easy;
using System.Linq;

Week week = new Week();


var iterator = week.GetEnumerator();

while (iterator.MoveNext())
{
    System.Console.WriteLine(iterator.Current);
}


