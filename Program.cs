using System.Collections;
using System.Diagnostics.Metrics;

namespace DataTypesVariables

{
    public class Program

    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ceiling: {0}", Math.Ceiling(15.3));
            Console.WriteLine("Floor: {0}", Math.Floor(15.3));
            Console.WriteLine("Min: {0}", Math.Min(15.3, 16));
            Console.WriteLine("Max: {0}", Math.Max(15.3, 16));
            Console.WriteLine("3^2: {0}", Math.Pow(3, 2));
            Console.WriteLine("Pi: {0}", Math.PI);
            Console.WriteLine("Square root of 25: {0}", Math.Sqrt(25));
            Console.WriteLine("Absolute: {0}", Math.Abs(-25));
        }
    }

}
