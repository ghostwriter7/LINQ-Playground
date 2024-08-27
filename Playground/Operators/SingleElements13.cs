namespace Playground.Operators;

public class SingleElements13
{
    public void Demo()
    {
        var ints = new[] { 1, 2, 3, 4, 5 };

        var first = ints.First(); // 1
        var firstGreaterThan2 = ints.First(x => x > 2); // 3
        var firstGreaterThan10 = ints.First(x => x > 10); // Exception
        var firstGreaterThan10Safe = ints.FirstOrDefault(x => x > 10); // 0 - default

        var last = ints.Last(); // 5
        var lastLessThanFive = ints.Last(x => x < 5); // 4

        var singleElement = ints.Single(); // Exception, more than 1 element
        var singleElement2 = ints.SingleOrDefault(); // Exception, more than 1 element, gives default only if list is empty
        var singleElement3 = new[] { 100 }.Single(); // 100

        var elementAtIndex1 = ints.ElementAt(1); // safe, as not every IEnumerable impl indexing;
        var elementAtIndex100Safe = ints.ElementAtOrDefault(100); // ElementAt will iterate the collection, not cheap
        var elementAtIndex1WithIndexer = ints[1];
        
    }
}