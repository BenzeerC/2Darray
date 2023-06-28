using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Darray
{
    internal class program3
    {
        //WAP to print all negative elements in an array and also count total number of negative elements in an array.
        static void Main(string[] args)
        {
            int[] a = new int[100];
            int n, i;
            Console.WriteLine("Enter size of an Array:");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter elements in array:");

            for (i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Negative elements in array are:");
            for (i = 0; i < n; i++)
            {
                if (a[i] < 0)
                {
                    Console.WriteLine(a[i]);
                }

            }
            Console.ReadLine();
        }
    }
}

