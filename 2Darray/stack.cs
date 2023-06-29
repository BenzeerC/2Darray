using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Darray
{
    internal class stack
    {
        static void Main(string[] args)
        {
            //Stack --> LIFO (Last in first out)
            Stack stack1 = new Stack();
            stack1.Push(55);
            stack1.Push("ID");
            stack1.Push(78);
            stack1.Push("Department");

            stack1.Pop();


            Console.WriteLine($"Top element in the stack: {stack1.Peek()}");

            foreach(var item in stack1) Console.WriteLine(item);



        }

    }
}
