using System.Collections;
using System.Diagnostics.Metrics;
using System.Text.RegularExpressions;

namespace DataTypesVariables

{
    public class Program

    {
        public static void Main(string[] args)
        {
            Regex regex = new Regex(@"\d");

            string text = "Hi there, my number is 12313";

            MatchCollection matches = regex.Matches(text);

            Console.WriteLine(matches.Count);

            foreach (Match hit in matches)
            {
                GroupCollection group = hit.Groups;
                Console.WriteLine("Group Collection: {0} hits found in: \n {1}", group[0].Value, group[1].Index);
                Console.WriteLine("{0} hits found in: \n {1}", hit.Value, hit.Index);
            }
        }
    }

}
