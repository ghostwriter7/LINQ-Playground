namespace Playground.Operators;

public class Quantifying09
{
    public void Demo()
    {
        int[] ints = { 1, 2, 3, 4, 5, 6 };
        var allIntsGreaterThanZero = ints.All(x => x > 0);
        var anyNumberLessThanTwo = ints.Any(x => x < 2);
        var isCollectionEmpty = ints.Any();
        var doesContainThree = ints.Contains(3);
    }
}