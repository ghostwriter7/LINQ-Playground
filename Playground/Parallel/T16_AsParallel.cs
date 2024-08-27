namespace Playground.Parallel;

public class T16_AsParallel
{
    public static void Demo()
    {
        const int count = 50;
        var ints = Enumerable.Range(1, count);
        var results = new int[count];
        
        ints.AsParallel().ForAll(item =>
        {
            var result = item * item * item;
            Console.WriteLine($"Result: {result} computed by ({Task.CurrentId})");
            results[item - 1] = result;
        });

        // to enforce picking up items in order by threads
        var cubes = ints.AsParallel().AsOrdered().Select(x => x * x * x);
    }
}