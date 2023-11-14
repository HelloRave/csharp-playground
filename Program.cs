using csharp_playground;
using System.Collections;
using System.Diagnostics.Metrics;
using System.Text.RegularExpressions;

namespace DataTypesVariables

{
    public class Program

    {
        public static void Main(string[] args)
        {
            AudioSystem audioSystem = new AudioSystem();
            RenderingEngine renderingEngine = new RenderingEngine();
            Player player1 = new Player("SteelCow");
            Player player2 = new Player("DoggoSilva");

            GameEventManager.TriggerGameStart();

            Console.WriteLine("Press key to end");

            Console.Read();

            GameEventManager.TriggerGameOver();
        }
    }
     
}
