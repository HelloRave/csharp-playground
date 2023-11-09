using System.Collections;
using System.Diagnostics.Metrics;
using System.Text.RegularExpressions;

namespace DataTypesVariables

{
    public class Program

    {
        public static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Please provide args");
                Console.ReadKey();
                return;
            }
            Console.WriteLine(args[0]);
            Console.ReadKey();
        }
    }

}
