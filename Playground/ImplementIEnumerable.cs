using System.Collections;

namespace Playground;

public class ImplementIEnumerable
{
    public static void Demo()
    {
        var parameters = new Params("a", "b", "c");
        foreach (var param in parameters)
        {
            Console.WriteLine($"Parameter is {param}");
        }

        var person = new Person("Jack", "Robins", "Pinkman");
        var hasJackName = person.Names.Contains("Jack");
    }

    private class Person
    {
        private readonly string _firstName, _middleName, _lastName;

        public Person(string firstName, string middleName, string lastName)
        {
            _firstName = firstName;
            _middleName = middleName;
            _lastName = lastName;
        }

        public IEnumerable<string> Names
        {
            get
            {
                yield return _firstName;
                yield return _middleName;
                yield return _lastName;
            }
        }
    }
    
    public class Params : IEnumerable<string>
    {
        private readonly string _param1, _param2, _param3;

        public Params(string param1, string param2, string param3)
        {
            _param1 = param1;
            _param2 = param2;
            _param3 = param3;
        }


        public IEnumerator<string> GetEnumerator()
        {
            yield return _param1;
            yield return _param2;
            yield return _param3;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}