﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_playground
{
    internal class Chair: Furniture, IDestroyable
    {
        public string DestructionSound { get; set; }
        public Chair(string color, string material)
        {
            this.Color = color;
            this.Material = material;
            DestructionSound = "DestroyChair.mp3";
        }
        public void Destroy()
        {
            Console.WriteLine("The {0} Chair was destroyed", Color);
            Console.WriteLine("Destruction Sound: {0}", DestructionSound);
        }
    }
}
