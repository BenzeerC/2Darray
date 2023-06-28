using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Darray
{
    internal class Program1
    {
        //WAP to search for a given number in an array and accordingly print the index if exists

        static void Main(string[] args)
        {
            int[] grads = { 30, 430, 23, 10 };
            bool found = false;
            int n;
            Console.WriteLine("Enter a number:");
            n = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < grads.Length; i++)
            {
                if (grads[i] == n) 
                {
                    Console.WriteLine("We Found!\n");
                    found = true; 
                    break;
                }
              
            }
            if(!found)
            {
                Console.WriteLine("Not found");
            }
        }
    }
}
