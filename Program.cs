using csharp_playground;
using System.Collections;
using System.Diagnostics.Metrics;

namespace DataTypesVariables

{

    public class Program

    {
        public static void Main(string[] args)
        {
            string text = File.ReadAllText(@"C:\Users\weiwei.huang\Desktop\VMShare\new.txt");
            Console.WriteLine(text);

            string[] lines = File.ReadAllLines(@"C:\Users\weiwei.huang\Desktop\VMShare\new.txt");
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

            string[] textLines = { "first line", "second line", "third line" };
            File.WriteAllLines(@"C:\Users\weiwei.huang\Desktop\VMShare\new.txt", textLines);

            string fileName = Console.ReadLine() ?? "testFile";
            string input = Console.ReadLine() ?? "no input";

            File.WriteAllText(@"C:\Users\weiwei.huang\Desktop\VMShare\" + fileName + ".txt", input);

            using (StreamWriter file = new StreamWriter(@"C:\Users\weiwei.huang\Desktop\VMShare\testFile.txt")) 
            {
                foreach (string line in lines)
                {
                    if (line.Contains("third"))
                    {
                        file.WriteLine(line);
                    }
                }
            }

            using (StreamWriter file = new StreamWriter(@"C:\Users\weiwei.huang\Desktop\VMShare\testFile.txt", true))
            {
                file.WriteLine("Previous entries not overwritten");
            }

        }
    }

}
