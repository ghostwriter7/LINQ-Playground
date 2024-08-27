namespace Playground.Operators;

public class Projection04
{
    public static void SelectUsage()
    {
        var ints = Enumerable.Range(1, 3);
        var squares = ints.Select(x => x * x);

        var text = "This is a sample sentence";
        var wordLengths = text.Split().Select(word => word.Length);

        var wordsAndLengths = text.Split().Select(word => new { Word = word, Size = word.Length });

        var rand = new Random();
        var randomNumbers = Enumerable.Range(1, 10).Select(_ => rand.Next(100));

        var strings = new[] { "orange,apple,strawberry", "blueberry", "banana,nuts" };
        var flatList = strings.SelectMany(str => str.Split(','));

        string[] colors = { "blue", "orange", "red" };
        string[] objects = { "car", "house", "plane" };
        var carthesianProduct = colors.SelectMany(_ => objects, (c, o) => new { Color = c, Obj = o });
    }
}