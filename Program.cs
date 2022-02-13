// See https://aka.ms/new-console-template for more information
// The client code may or may not know about the Concrete Iterator
// or Collection classes, depending on the level of indirection you
// want to keep in your program.
using Iterator_Design_Pattern;

var collection = new WordsCollection();
collection.AddItem("First");
collection.AddItem("Second");
collection.AddItem("Third");

Console.WriteLine("Straight traversal:");

foreach (var element in collection)
{
    Console.WriteLine(element);
}

Console.WriteLine("\nReverse traversal:");

collection.ReverseDirection();

foreach (var element in collection)
{
    Console.WriteLine(element);
}
