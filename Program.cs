namespace DataTypesVariables

{

    public class Program

    {

        public static void Main(string[] args)

        {
            DisplayCharacter('f');  // Output: A lowercase letter: f
            DisplayCharacter('R');  // Output: An uppercase letter: R
            DisplayCharacter('8');  // Output: A digit: 8
            DisplayCharacter(',');  // Output: Not alphanumeric character: ,

            DisplayMeasurement(-4);  // Output: Measured value is -4; too low.
            DisplayMeasurement(5);  // Output: Measured value is 5.
            DisplayMeasurement(30);  // Output: Measured value is 30; too high.
            DisplayMeasurement(double.NaN);  // Output: Failed measurement.

            Console.WriteLine(GetWeatherDisplay(15));  // output: Cold.
            Console.WriteLine(GetWeatherDisplay(27));  // output: Perfect!

            void DisplayCharacter(char ch)
            {
                if (char.IsUpper(ch))
                {
                    Console.WriteLine($"An uppercase letter: {ch}");
                }
                else if (char.IsLower(ch))
                {
                    Console.WriteLine($"A lowercase letter: {ch}");
                }
                else if (char.IsDigit(ch))
                {
                    Console.WriteLine($"A digit: {ch}");
                }
                else
                {
                    Console.WriteLine($"Not alphanumeric character: {ch}");
                }
            }

            void DisplayMeasurement(double measurement)
            {
                switch (measurement)
                {
                    case < 0.0:
                        Console.WriteLine($"Measured value is {measurement}; too low.");
                        break;

                    case > 15.0:
                        Console.WriteLine($"Measured value is {measurement}; too high.");
                        break;

                    case double.NaN:
                        Console.WriteLine("Failed measurement.");
                        break;

                    default:
                        Console.WriteLine($"Measured value is {measurement}.");
                        break;
                }
            }

            string GetWeatherDisplay(double tempInCelsius) => tempInCelsius < 20.0 ? "Cold." : "Perfect!";

        }


    }

}
