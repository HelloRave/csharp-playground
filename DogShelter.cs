using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_playground
{
    internal class DogShelter : IEnumerable<Dog>
    {
        public List<Dog> dogs;
        public DogShelter()
        {
            dogs = new List<Dog>()
            {
                new("Casper", false),
                new("Sif", true),
                new("Orea", false),
                new("Pixel", false),
            };
        }

        public IEnumerator<Dog> GetEnumerator()
        {
            return dogs.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
