using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Darray
{
    internal class program8
    {
        //WAP to find the second smallest element in an array.
        static void Main(string[] args)
        {
            int[] arr = { 11, 3, 15, 10, 34, 1 };
            int n = arr.Length;

            // sorting the array using
            // in-built sort function
            Array.Sort(arr);

            // printing the desired element
            Console.WriteLine("smallest element is " + arr[0]);
            Console.WriteLine("second smallest element is "
                              + arr[1]);
        }
    }
}
