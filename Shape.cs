using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_playground
{
    internal class Shape
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public Shape() 
        {
            Height = 0;
            Width = 0;
        }
        public Shape(int height, int width)
        {
            Height = height;
            Width = width;
        }

        public void ShowDetails()
        {
            Console.WriteLine("ShowDetails of base class...");
        }
        public virtual void Draw()
        {
            Console.WriteLine("Performing base class drawing tasks");
        }
    }
}
