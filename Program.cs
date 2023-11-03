using System.Collections;
using System.Diagnostics.Metrics;

namespace DataTypesVariables

{
    struct Game
    {
        public string name;
        public string developer;
        public double rating;
        public string releaseDate;

        public void Display()
        {
            Console.WriteLine("Game 1's name is {0}", name);
        }
    }
    public class Program

    {
        public static void Main(string[] args)
        {
            Game game1;
            game1.name = "Pokemon Go";
            game1.developer = "Ash";
            game1.rating = 5;
            game1.releaseDate = "02-02-2022";
            game1.Display();
        }
    }

}
