namespace Playground.Parallel;

public class T17_ErrorsAndCancellation
{
    public static void Demo()
    {
        var cts = new CancellationTokenSource();
        
        var ints = ParallelEnumerable.Range(1, 10000);
        
        var results = ints.WithCancellation(cts.Token).Select(x =>
        {
            var result = Math.Log10(x);

            if (result > 100) throw new InvalidOperationException($"Woah pardner, result is {result}");
            
            Console.WriteLine($"x = {x}, tid = {Task.CurrentId}");
            return result;
        });

        try
        {
            foreach (var result in results)
            {
                Console.WriteLine($"result is {result}");

                if (result > 0.9)
                    cts.Cancel();
            }
        }
        catch (AggregateException ae)
        {
            ae.Handle(e =>
            {
                Console.WriteLine($"Exception: {e.GetType().Name}, Message: {e.Message}");
                return true;
            });
        }
        catch (OperationCanceledException e)
        {
            Console.WriteLine("Cancelled...");
        }
    }
}