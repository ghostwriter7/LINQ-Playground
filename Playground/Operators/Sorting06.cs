namespace Playground.Operators;

public class Sorting06
{
    public void Demo()
    {
        var str = "This is a sample sentence";
        var reversed = new string(str.Reverse().ToArray());
    }
    
    public void OrderBy()
    {
        Func<IEnumerable<int>, string> toString = (values) => string.Join(",", values);
        var random = new Random();
        var randomNumberGenerator = Enumerable.Range(1, 10)
            .Select(_ => random.Next(10) - 5);

        var sortedNumbers = randomNumberGenerator.Order();
        var sortedDescNumbers = randomNumberGenerator.OrderDescending();
    }

    public void OrderByComplexObjects()
    {
        var people = new List<Person>()
        {
            new("Jack", 25),
            new("Stephan", 25),
            new("Tom", 35),
            new("John", 18),
            new("Hulk", 42)
        };

        var peopleSortedByAgeThenName = people.OrderByDescending(x => x.Age)
            .ThenBy(x => x.Name);
    }

    private record Person(string Name, int Age);
}