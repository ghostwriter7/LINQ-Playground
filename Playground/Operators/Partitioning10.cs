namespace Playground.Operators;

public class Partitioning10
{
    public static void Demo()
    {
        var ints = Enumerable.Range(1, 100);

        var skip10Items = ints.Skip(10);
        var takeNext20Items = skip10Items.Take(20);

        var skipNumbersLessThan20 = ints.SkipWhile(x => x <= 20);
        var takeNumbersLessThan50 = ints.TakeWhile(x => x <= 50);

        var skip20LastItems = ints.SkipLast(20);
        var take20LastItems = ints.TakeLast(20);
    }
}