namespace DataTypesVariables

{

    public class Program

    {

        static int age = 15;
        static string name = "test";

        public static void Main(string[] args)

        {
            // 1. String concatenation
            Console.WriteLine("String Concatenation: Name is " + name + " age is " + age);

            // 2. String formatting
            Console.WriteLine("String formatting: Name is {0} and age is {1}", name, age);

            // 3. String interpolation
            Console.WriteLine($"String formatting: Name is {name} and age is {age}", name, age);

            // 4. Verbatim strings
            Console.WriteLine(@"Hello world \n
            New paragraph and empty line following...

            ");

        }

    }

}
