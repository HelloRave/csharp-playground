using System.Collections;
using System.Diagnostics.Metrics;

namespace DataTypesVariables

{
    enum Day { Mo, Tu, We, Th, Fr = 6, Sa, Su };
    public class Program

    {
        public static void Main(string[] args)
        {
            Day day = Day.Mo;
            Console.WriteLine(day);
            Console.WriteLine((int)day);

            foreach (var eachDay in Enum.GetValues(typeof(Day)))
            {
                Console.WriteLine(eachDay);
            }
        }
    }

}
