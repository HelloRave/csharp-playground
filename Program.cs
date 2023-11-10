using csharp_playground;
using System.Collections;
using System.Diagnostics.Metrics;
using System.Text.RegularExpressions;

namespace DataTypesVariables

{
    public class Program

    {
        internal delegate bool FilterDelegate(Person person);
        public static void Main(string[] args)
        {
            // Example 1
            List<string> names = new List<string>() { "Aiden", "Sif", "Walter", "Anatoli" };

            Console.WriteLine("----before----");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            names.RemoveAll(Filter);

            Console.WriteLine("----after----");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            // Example 2
            List<Person> values = new List<Person>()
            {
                new Person() { Name = "Aiden", Age = 41 },
                new Person() { Name = "Sif", Age = 69 },
                new Person() { Name = "Walter", Age = 12 },
                new Person() { Name = "Anatoli", Age = 25 },
            };

            DisplayPeople("----Kids----", values, IsMinor);
            DisplayPeople("----Adults----", values, IsAdult);

            FilterDelegate filter = (Person p) =>
            {
                return p.Age >= 20 && p.Age <= 30;
            };

            DisplayPeople("----Between 20-30----", values, filter);
            DisplayPeople("----All----", values, p => true);
        }
        public static bool Filter(string s)
        {
            return s.Contains('i');
        }

        internal static void DisplayPeople(string title, List<Person> people, FilterDelegate filter)
        {
            Console.WriteLine(title);
            foreach (Person person in people)
            {
                if(filter(person))
                {
                    Console.WriteLine("{0}, {1} years old", person.Name, person.Age);
                }
            }
        }

        internal static bool IsMinor(Person person)
        {
            return person.Age < 18;
        }

        internal static bool IsAdult(Person person)
        {
            return person.Age > 18;
        }


    }

}
