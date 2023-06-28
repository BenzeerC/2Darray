using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Darray
{
    internal class program5
    {//  WAP to find the maximum and minimum value in an array.
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 100, 105, 203, 109, 187 };
            int i, max, min, n;
            // size of the array
            n = 5;
            max = arr[0];
            min = arr[0];
            for (i = 1; i < n; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.Write("Maximum element = {0}", max);
      
            Console.Write("\nMinimum element = {0}", min);
   
}   }   }

