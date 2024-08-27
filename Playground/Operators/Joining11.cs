namespace Playground.Operators;

public class Joining11
{
    public static void Demo()
    {
        var people = new Person[]
        {
            new("Jane", "jane@hotmail.com"),
            new("John", "john@foo.com"),
            new("ant", string.Empty)
        };

        var records = new Record[]
        {
            new("jane@hotmail.com", "JaneFoo"),
            new("jane@hotmail.com", "JaneHome"),
            new("john@foo.com", "John1980")
        };

        var query = people.Join(records,
            person => person.Email,
            skypeRecord => skypeRecord.Email,
            (person, skypeRecord) => new { Name = person.Name, SkypeId = skypeRecord.SkypeId });

        people.GroupJoin(records, 
            person => person.Email,
            skypeRecord => skypeRecord.Email,
            (person, skypeRecords) => new
                { Name = person.Name, SkypeIds = skypeRecords.Select(x => x.SkypeId).ToArray() });
    }

    public record Person(string Name, string Email);

    public record Record(string Email, string SkypeId);
}