using csharp_playground;
using System.Collections;
using System.Diagnostics.Metrics;

namespace DataTypesVariables

{

    public class Program

    {
        public static void Main(string[] args)
        {
            Circle circle = new();
            Circle circle2 = new(1, 1, 3.14f);
            Rectangle rectangle = new Rectangle();
            List<Shape> shapes = new ()
            {
                circle, circle2, rectangle
            };

            foreach (var item in shapes)
            {
                item.Draw();
                Circle? someCircle = item as Circle;
                if (someCircle == null)
                {
                    Console.WriteLine("Shape is not circle");
                }
                if (someCircle is Circle)
                {
                    Console.WriteLine("Shape is circle");
                }
            }

            Console.WriteLine();

            Shape rectangle2 = new Rectangle();
            rectangle.ShowDetails();
            rectangle2.ShowDetails();
            rectangle2.Draw();

            Console.WriteLine();

            SmallRectangle smallRectangle = new ();
            smallRectangle.ShowDetails();
            smallRectangle.Draw();

            Console.WriteLine();

            ExtendSmallRectangle extendSmallRectangle = new ();
            extendSmallRectangle.Draw();
            extendSmallRectangle.ShowDetails();

            Console.WriteLine();

            Shape random = new ExtendSmallRectangle ();
            random.Draw();
        }
    }

}
