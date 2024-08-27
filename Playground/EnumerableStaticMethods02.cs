namespace Playground;

public class EnumerableStaticMethods02
{
    public static void Demo()
    {
        var emptyList = Enumerable.Empty<int>();

        var repeatedList = Enumerable.Repeat("hello", 3);

        var intRange = Enumerable.Range(1, 10);

        var letters = Enumerable.Repeat('a', 'z' - 'a').Select(c => (char) c);

        var letterSequences = Enumerable.Repeat(1, 10).Select(count => new string('x', count));
    }
}