using csharp_playground;
using System.Collections;
using System.Diagnostics.Metrics;

namespace DataTypesVariables

{

    public class Program

    {

        public static void Main(string[] args)

        {
            //Non-Generic Collections
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(1);
            myArrayList.Add("Hello");
            myArrayList.Add(3.142);
            myArrayList.Add(2);
            myArrayList.Add("Hello");
            myArrayList.Add("Hello");

            myArrayList.Remove(1);
            myArrayList.RemoveAt(0);
            myArrayList.RemoveRange(0, 2);

            Console.WriteLine(myArrayList.Count);

            foreach (object item in myArrayList)
            {
                Console.WriteLine(item);
            }


            //Generic Collections (Indexable)
            var numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            numbers.Add(1);
            numbers.RemoveAt(2);

            foreach (var item in numbers)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }

    }

}
