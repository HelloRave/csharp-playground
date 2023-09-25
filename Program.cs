namespace DataTypesVariables

{

    public class Program

    {

        static string escapedString = "\"Hello World\" \\ \na line break";

        public static void Main(string[] args)

        {
            
            Console.WriteLine(escapedString); 
            /** output:
             "Hello World" \
             a line break */

        }

    }

}
