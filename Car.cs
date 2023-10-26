using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_playground
{
    internal class Car: Vehicle, IDestroyable
    {
        public string DestructionSound { get; set; }
        public List<IDestroyable> DestroyablesNearby;
        public Car(float speed, string color)
        {
            this.Speed = speed;
            this.Color = color;
            DestructionSound = "DestroyCar.mp3";
            DestroyablesNearby = new List<IDestroyable>();
        }
        public void Destroy()
        {
            Console.WriteLine("Car is destroyed, sound {0} ", DestructionSound);
            foreach (IDestroyable destroyable in DestroyablesNearby)
            {
                destroyable.Destroy();
            }
        }
    }
}
