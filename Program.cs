namespace DataTypesVariables

{

    public class Program

    {

        public static void Main(string[] args)

        {
            WriteSomething();
            WriteSomethingSpecific("Hello World");
        }

        public static void WriteSomething()
        {
            Console.WriteLine("Hello World");
        }

        public static void WriteSomethingSpecific(string myText)
        {
            Console.WriteLine(myText);
        }

    }

}
