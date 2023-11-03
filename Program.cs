using System.Collections;
using System.Diagnostics.Metrics;
using System.Text.RegularExpressions;

namespace DataTypesVariables

{
    public class Program

    {
        public static void Main(string[] args)
        {
            DateTime dateTime = new DateTime(2018, 5, 31);

            Console.WriteLine("Date is {0}", dateTime);
            Console.WriteLine("Today: {0}", DateTime.Today);
            Console.WriteLine("Time now: {0}", DateTime.Now);
            Console.WriteLine("Minutes of time now: {0}", DateTime.Now.Minute);
            Console.WriteLine("Tomorrow: {0}", DateTime.Now.AddDays(1));

            Console.WriteLine("Write date in yyyy-mm-dd");
            string input = Console.ReadLine();
            DateTime output;
            if (DateTime.TryParse(input, out output))
            {
                Console.WriteLine(output);
                TimeSpan daysPassed = DateTime.Now.Subtract(output);
                Console.WriteLine("Days passed: {0}", daysPassed.Days);
            }
        }
    }

}
