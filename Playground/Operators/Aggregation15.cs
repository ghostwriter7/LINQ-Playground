using System.Drawing;

namespace Playground.Operators;

public class Aggregation15
{
    public void Demo()
    {
        var numbers = Enumerable.Range(1, 10);

        var sum = numbers.Sum();
        var sumManually = numbers.Aggregate((partialResult, current) => partialResult + current);
        var product = numbers.Aggregate(1, (partialProduct, currentNumber) => partialProduct * currentNumber);

        var average = numbers.Average();

        var words = new[] { "one", "two", "three" };
        var joinedWords = words.Aggregate((p, x) => $"{p},{x}");

        var count = numbers.Count();


        var rectangles = new[]
            { new Rectangle(0, 0, 20, 20), new Rectangle(20, 20, 60, 60), new Rectangle(80, 80, 20, 20) };

        var bigRectangle = rectangles.Aggregate(Rectangle.Union);
    }
}