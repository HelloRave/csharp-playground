using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_playground
{
    internal class Rectangle: Shape
    {
        private readonly string Name;

        public Rectangle()
        {
            Name = "A rectangle";
        }
        public Rectangle(string name)
        {
            Name = name;
        }
        public new void ShowDetails()
        {
            Console.WriteLine("Shape name is: {0}", Name);
        }
        public override void Draw()
        {
            Console.WriteLine("Drawing a rectangle");
            base.Draw();
        }
    }
}
