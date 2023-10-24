using csharp_playground;
using System.Collections;
using System.Diagnostics.Metrics;

namespace DataTypesVariables

{

    public class Program

    {

        public static void Main(string[] args)

        {
            Radio radio = new (false, "Sony");
            radio.ListenRadio();
            radio.SwitchOn();
            radio.ListenRadio();

            Console.WriteLine();

            Dog puppy = new("Alvin", 5);
            puppy.Eat();
            puppy.MakeSound();
            puppy.Play();
            puppy.IsHappy = false;
            puppy.Play();
        }

    }

}
