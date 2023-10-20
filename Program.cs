using csharp_playground;
using System.Collections;
using System.Diagnostics.Metrics;

namespace DataTypesVariables

{

    public class Program

    {

        public static void Main(string[] args)

        {

            // Stack
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            Console.WriteLine("Top of stack is {0}", stack.Peek());
            stack.Push(2);
            Console.WriteLine("Top of stack is {0}", stack.Peek());
            stack.Push(3);
            Console.WriteLine("Top of stack is {0}", stack.Peek());
            stack.Push(4);
            int popValue = stack.Pop();
            Console.WriteLine("Popped value {0} from stack", popValue);
            Console.WriteLine("Top of stack is {0}", stack.Peek());

            // Queue
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            Console.WriteLine("Top of queue is {0}", queue.Peek());
            queue.Enqueue(2);
            Console.WriteLine("Top of queue is {0}", queue.Peek());
            queue.Enqueue(3);
            Console.WriteLine("Top of queue is {0}", queue.Peek());
            queue.Enqueue(4);
            int dequeueValue = queue.Dequeue();
            Console.WriteLine("Dequeued value {0} from queue", dequeueValue);
            Console.WriteLine("Top of queue is {0}", queue.Peek());

        }

    }

}
