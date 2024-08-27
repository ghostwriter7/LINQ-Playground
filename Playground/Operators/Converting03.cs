using System.Collections;

namespace Playground.Operators;

public class Converting03
{
    public static void HandlingOldCollectionTypesLikeArrayList()
    {
        var list = new ArrayList(); // Weakly typed, does not implement IEnumerable
        list.Add(1);
        list.Add(2);
        // Cast converts it into IEnumerable<int> and enables LINQ operators
        var result = list.Cast<int>().Select(x => x * 2).ToList();
    }

    public static void ConvertingToDifferentCollections()
    {
        var sequence = Enumerable.Range(1, 10);
        var asFixedLengthArray = sequence.ToArray();
        var asFlexibleList = sequence.ToList();
        var asDictionary = sequence.ToDictionary(x => x * 100, x => x % 2 == 0);
    }
}