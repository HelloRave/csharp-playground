namespace DataTypesVariables

{

    public class Program

    {
        // Explicit conversion
        static double age = 15.55;
        static int myInt = (int)age;

        // Implicit conversion
        static float myFloat = 13.37f;
        static double myNewDouble = myFloat;

        static int num = 1;
        static long bigNum = num;

        // Type conversion
        static string myString = myNewDouble.ToString();

        public static void Main(string[] args)

        {

            Console.WriteLine(myInt);
            Console.WriteLine(myNewDouble);
            Console.WriteLine(bigNum);
            Console.WriteLine(myString);
        }

    }

}
