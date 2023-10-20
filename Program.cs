using csharp_playground;
using System.Collections;
using System.Diagnostics.Metrics;

namespace DataTypesVariables

{

    public class Program

    {

        public static void Main(string[] args)

        {
            Employee[] employees =
            {
                new Employee("CEO", "Alan", 95, 200),
                new Employee("Manager", "Grace", 35, 25),
                new Employee("HR", "Loren", 32, 21),
                new Employee("Secretary", "Maple", 28, 18),
                new Employee("Intern", "Leo", 22, 8)
            };

            Dictionary<int, string> myDictionary = new Dictionary<int, string>()
            {
                { 1, "one" }, { 2, "two" }, { 3, "three" }
            };

            Dictionary<string, Employee> employeesDictionary = new Dictionary<string, Employee>();



            foreach (Employee employee in employees)
            {
                employeesDictionary.Add(employee.Role, employee);
            }

            // Delete
            if (employeesDictionary.Remove("Intern"))
            {
                Console.WriteLine("Employee with Key {0} was removed", "Intern");
            }

            for (int i = 0; i < employeesDictionary.Count; i++)
            {
                KeyValuePair<string, Employee> keyValuePair = employeesDictionary.ElementAt(i);
                
                Console.WriteLine("Key: {0}", keyValuePair.Key);

                Employee employee = keyValuePair.Value;
                Console.WriteLine("Employee Name: {0}", employee.Name);
            }

            Console.WriteLine();

            if (employeesDictionary.ContainsKey("CEO"))
            {
                Employee emp1 = employeesDictionary["CEO"];
                Console.WriteLine($"Employee Name: {emp1.Name}, Salary: {emp1.Salary}");

                // Update
                employeesDictionary["CEO"] = new Employee("CEO", "Bisky", 1, 1);
                Employee emp2 = employeesDictionary["CEO"];
                Console.WriteLine($"Employee Name: {emp2.Name}, Salary: {emp2.Salary}");
            }

            if (employeesDictionary.TryGetValue("CEO", out Employee? result))
            {
                Console.WriteLine("Employee Name: {0}", result.Name);
            }
            else
            {
                Console.WriteLine("Key not found");
            }

        }

    }

}
