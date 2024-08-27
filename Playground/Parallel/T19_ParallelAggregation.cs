namespace Playground.Parallel;

public class T19_ParallelAggregation
{
    public static void Demo()
    {
        var sum = ParallelEnumerable.Range(1, 1000)
            .Aggregate(
                0 /* SEED */,
                (partialSum, current) => partialSum += current, /* Per Task */
                (total, subtotal) => total += subtotal, /* Merge threads */
                result => result /* Post Processing */
            );

        Console.WriteLine(sum);
    }
}