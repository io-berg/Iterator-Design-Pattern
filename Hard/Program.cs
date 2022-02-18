using System;
using System.Collections;
using System.Collections.Generic;

/*
    Iterator designmönstret är till för att kunna nå elementen av ett samlingsobjekt,
    i sekvens utan att exponera det som ligger bakom samlingen.    
*/
public class Program
{
    public static void Main(string[] args)
    {
        KonkretAggregat samlingAvElement = new KonkretAggregat();
        samlingAvElement[0] = "Element 1";
        samlingAvElement[1] = "Element 2";
        samlingAvElement[2] = "Element 3";
        samlingAvElement[3] = "Element 4";
        // Skapa en Iterator och tillhandahåll ett aggregat(samling).
        AbstraktIterator iteratorExempel = samlingAvElement.CreateIterator();
        Console.WriteLine("Itererar igenom samling och skriver ut dess element:");
        object element = iteratorExempel.First();
        while (element != null)
        {
            Console.WriteLine(element);
            element = iteratorExempel.Next();
        }
        Console.ReadKey();
    }
}

// Abstrakt klass för aggregat, ser till att ärvande klasser måste innehålla en implementation av AbstraktIterator klassen.
public abstract class AbstraktAggregat
{
    public abstract AbstraktIterator CreateIterator();
}


// Konkret klass för våra samlingar, ärvd ifrån den abstrakta.
public class KonkretAggregat : AbstraktAggregat
{
    List<object> items = new List<object>();
    public override AbstraktIterator CreateIterator()
    {
        return new KonkretIterator(this);
    }
    // Räknar antalet element i vår samling.
    public int Count
    {
        get { return items.Count; }
    }
    // Indexerare, pekaren för vilket element vi står på.
    public object this[int index]
    {
        get { return items[index]; }
        set { items.Insert(index, value); }
    }
}

// Abstrakt klass för Iteratorn, ser till att ärvda klasser måste innehålla dessa 4 attribut.
public abstract class AbstraktIterator
{
    public abstract object First();
    public abstract object Next();
    public abstract bool IsDone();
    public abstract object CurrentItem();
}

// Konrekt klass av iteratorn, ärvd utifrån den abstrakta.
public class KonkretIterator : AbstraktIterator
{
    KonkretAggregat aggregate;
    int current = 0;
    // Constructor
    public KonkretIterator(KonkretAggregat aggregate)
    {
        this.aggregate = aggregate;
    }
    // Hämtar första elementet i vår samling.
    public override object First()
    {
        return aggregate[0];
    }
    // Hämtar nästa element i vår samling.
    public override object Next()
    {
        object ret = null;
        if (current < aggregate.Count - 1)
        {
            ret = aggregate[++current];
        }
        return ret;
    }
    // Returnerar det nuvarande "valda" elementet.
    public override object CurrentItem()
    {
        return aggregate[current];
    }
    // Kollar utifall vi har gått igenom hela samlingen.
    public override bool IsDone()
    {
        return current >= aggregate.Count;
    }
}
