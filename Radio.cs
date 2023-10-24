using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_playground
{
    internal class Radio: ElectricalDevice
    {
        public Radio(bool isOn, string brand): base(isOn, brand)
        {

        }

        public void ListenRadio()
        {
            if (IsOn)
            {
                Console.WriteLine("Listening to radio");
            }
            else
            {
                Console.WriteLine("Radio is off");
            }
        }

    }
}
