namespace DataTypesVariables

{

    public class Program

    {

        public static void Main(string[] args)

        {
            string userInput = Console.ReadLine();

            try
            {
                int userInputAsInt = int.Parse(userInput);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Done");
            }

        }


    }

}
