namespace Playground.Operators;

public class Equality12
{
    public void Demo()
    {
        var ints1 = new[] { 1, 2, 3, 4 };
        var ints2 = Enumerable.Range(1, 4);

        var isEqual = ints1 == ints2; // false, referential equality
        var isEqual2 = ints1.Equals(ints2); // false, referential equality
        var isSequenceEqual = ints1.SequenceEqual(ints2); // true
    }
}