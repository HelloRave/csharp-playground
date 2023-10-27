using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_playground
{
    internal class Circle: Shape
    {
        public float Radius;

        public Circle()
        {
            Radius = 1.0f;
        }
        public Circle(int height, int width, float radius): base(height, width)
        {
            Radius = radius;
        }

        public override void Draw()
        {
            Console.WriteLine("Circle: Height is {0} and width is {1} and radius is {2}", Height, Width, Radius);
            base.Draw();
        }
    }
}
