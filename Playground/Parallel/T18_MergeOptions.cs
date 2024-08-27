namespace Playground.Parallel;

public class T18_MergeOptions
{
    public static void Demo()
    {
        var ints = Enumerable.Range(1, 100).ToArray();

        var results = ints.AsParallel()
            .WithMergeOptions(ParallelMergeOptions.NotBuffered)
            .Select(x =>
            {
                var result = Math.Log10(x);
                Console.WriteLine($"P: {result}");
                return result;
            });

        foreach (var result in results)
        {
            Console.WriteLine($"C: {result}");
        }
    }
}