namespace DataTypesVariables

{

    public class Program

    {

        public static void Main(string[] args)

        {
            int num1 = 1;
            int num2;

            num2 = -num1;

            bool isSunny = true;

            Console.WriteLine($"Values are {num2} and {isSunny}", num2 , !isSunny);

            int num = 0;

            // Pre/Post-Increment/Decrement
            Console.WriteLine("num is {0}", num);
            Console.WriteLine("num is {0}", num++);
            Console.WriteLine("num is {0}", ++num);

            Console.WriteLine("num is {0}", num);
            Console.WriteLine("num is {0}", num--);
            Console.WriteLine("num is {0}", --num);
        }


    }

}
