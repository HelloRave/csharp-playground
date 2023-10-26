using csharp_playground;
using System.Collections;
using System.Diagnostics.Metrics;

namespace DataTypesVariables

{

    public class Program

    {

        public static void Main(string[] args)

        {
            Chair gamingChair = new("Brown", "Plastic");
            Chair officeChair = new("Red", "Wood");
            Car damagedCar = new(80f, "Green");

            damagedCar.DestroyablesNearby.Add(gamingChair);
            damagedCar.DestroyablesNearby.Add(officeChair);

            damagedCar.Destroy();
        }

    }

}
