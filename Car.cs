using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_playground
{
    internal class Car
    {
        private string _name;
        private int _hp;
        private string _writeOnly;
        public int HorsePower { get { return _hp; } set { _hp = value; } }

        //Auto Implemented Properties
        public int MaxSpeed { get; set; }

        public string ReadOnly { get; } = "Read only property";

        public string WriteOnly { set { _writeOnly = value; } }

        //Constructor
        public Car()
        {
            _name = "Car";
            _hp = 0;
            _writeOnly = "";
        }

        // Constructor
        public Car(string name, int hp = 0) 
        {
            _name = name;
            _hp = hp;
            _writeOnly = "";
            Console.WriteLine(name + " is created");
        }

        //Getter
        public string GetName() { return _name; }

        //Setters
        public void SetName(string name)
        {
            _name = name;
        }

        //Methods
        public void Drive() { Console.WriteLine("Car is driving"); }
    }
}
