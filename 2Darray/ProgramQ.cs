using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace _2Darray
{
    internal class ProgramQ
    {
        static void Main(string[] args)
        {
            System.Collections.Queue queue = new System.Collections.Queue();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);

            queue.Dequeue();

            Console.WriteLine($"First element in the list is: {queue.Peek()}");
            Console.WriteLine($"Total elements in the elements in the queue is:{queue.Count}");

            foreach (var item in queue) Console.WriteLine();
        }
       
    }
}
