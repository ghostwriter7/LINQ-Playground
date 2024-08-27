namespace Playground.Operators;

public class Set08
{
    public void Demo()
    {
        var word1 = "hellooooo";
        var word2 = "help";

        var distinctChars = word1.Distinct();
        var commonChars = word1.Intersect(word2);
        var allUniqueChars = word1.Union(word2);
        var uniqueCharsFromWord1 = word1.Except(word2);
    }
}