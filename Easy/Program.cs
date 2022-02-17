using Easy;

Week week = new Week();

foreach (var day in week)
{
    Console.WriteLine(day);
}


System.Console.WriteLine("Today is: " + week[4]);