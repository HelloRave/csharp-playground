using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_playground
{
    internal class SmallRectangle: Rectangle
    {
        public sealed override void Draw()
        {
            Console.WriteLine("This is a small rectangle");
            base.Draw();
        }
    }
}
