namespace Playground.Operators;

public class Filtering04
{
    public static void Demo()
    {
        var ints = Enumerable.Range(1, 10);
        var evens = ints.Where(x => x % 2 == 0);
        var oddSquares = ints.Select(x => x * x).Where(x => x % 2 == 1);

        object[] objects = { 1, 1.25, 3, 3.55f, "hello world" };
        var onlyInts = objects.OfType<int>();
        var onlyFloats = objects.OfType<float>();
    }
}