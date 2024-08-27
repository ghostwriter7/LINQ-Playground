namespace Playground.Operators;

public class Grouping07
{
    public void Demo()
    {
        var people = new List<Person>()
        {
            new("Jack", 25),
            new("Stephan", 25),
            new("Tom", 35),
            new("John", 18),
            new("Hulk", 42)
        };

        var byName = people.GroupBy(p => p.Name);
        var olderBy30Groups = people.GroupBy(p => p.Age > 30);
        var namesByAge = people.GroupBy(p => p.Age, p => p.Name);

        foreach (var item in byName)
        {
            Console.WriteLine($"These people share the name {item.Key}");
            foreach (var person in item)
                Console.WriteLine($"{person.Name} is {person.Age}");
        }
    }
    
    private record Person(string Name, int Age);
}