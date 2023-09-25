namespace DataTypesVariables

{

    public class Program

    {

        static string firstName = "Hello";
        static string lastName = "World";
        static string fullName = string.Concat(" ", firstName, lastName, " ");
        static string formatName = String.Format("My name is {0}", fullName);

        public static void Main(string[] args)

        {
            
            Console.WriteLine(fullName); // output: " Hello World "
            Console.WriteLine(firstName.Substring(2)); // output: "llo"
            Console.WriteLine(firstName.ToLower()); // output: "hello"
            Console.WriteLine(firstName.ToUpper()); // output: "HELLO"
            Console.WriteLine(fullName.Trim()); // output: "Hello World"
            Console.WriteLine(firstName.IndexOf('e')); // output: 1
            Console.WriteLine(String.IsNullOrWhiteSpace(firstName)); // output: false
            Console.WriteLine(formatName);

        }

    }

}
