namespace Playground.Operators;

public class Concatenation14
{
    public void Demo()
    {
        var integralTypes = new[] { typeof(int), typeof(short) };
        var decimalTypes = new[] { typeof(float), typeof(double) };

        var allTypes = integralTypes.Concat(decimalTypes);
        allTypes.Prepend(typeof(bool));
    }
}

public static class ExtensionMethods
{
    public static IEnumerable<T> Prepend<T>(this IEnumerable<T> values, T value)
    {
        yield return value;
        foreach (var item in values)
            yield return item;
    }
}