using csharp_playground;

namespace DataTypesVariables

{

    public class Program

    {

        public static void Main(string[] args)

        {
            Car myCar = new Car();
            Console.WriteLine(myCar.GetName());
            myCar.SetName("myCar");
            Console.WriteLine(myCar.GetName());

            Console.WriteLine(myCar.HorsePower);
            myCar.HorsePower = 1;
            Console.WriteLine(myCar.HorsePower);

            Console.WriteLine(myCar.ReadOnly);
            myCar.WriteOnly = "Write Only";

            myCar.Drive();
            
            Car bmw = new Car("bmw", 350);
            bmw.Drive();

        }


    }

}
