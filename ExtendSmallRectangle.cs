using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_playground
{
    internal class ExtendSmallRectangle: SmallRectangle
    {
        public new void Draw()
        {
            Console.WriteLine("Drawing extended small rectangle");
        }
    }
}
