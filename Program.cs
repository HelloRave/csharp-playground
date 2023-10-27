using csharp_playground;
using System.Collections;
using System.Diagnostics.Metrics;

namespace DataTypesVariables

{

    public class Program

    {

        public static void Main(string[] args)

        {
            DogShelter dogShelter = new ();

            foreach (Dog dog in dogShelter)
            {
                if (!dog.IsNaughtyDog)
                {
                    dog.GiveTreat(2);
                }
                else
                {
                    dog.GiveTreat(1);
                }
            }

            IEnumerable<int> unknownCollection;
            unknownCollection = GetCollection(1);
            foreach (int unknown in unknownCollection)
            {
                Console.WriteLine(unknown);
            }

            unknownCollection = GetCollection(2);
            CollectionSum(unknownCollection);
        }

        static IEnumerable<int> GetCollection(int option)
        {
            List<int> collection = new List<int>() { 1, 2, 3, 4, 5 };
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(6);
            queue.Enqueue(7);
            queue.Enqueue(8);
            queue.Enqueue(9);
            queue.Enqueue(10);

            if (option == 1)
            {
                return collection;
            }
            else if (option == 2)
            {
                return queue;
            }
            else
            {
                return new int[] { 11, 12, 13, 14, 15 };
            }
        }

        static void CollectionSum(IEnumerable<int> collection)
        {
            int sum = 0;
            foreach (int num in collection)
            {
                sum += num;
            }

            Console.WriteLine("Sum is {0}", sum);
        }

    }

}
