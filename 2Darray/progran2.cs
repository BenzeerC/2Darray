using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _2Darray
{
    internal class progran2
    {
        ///Write two methods that return the average of an array with following headers.
        //i.public static int average(int[] array)
        //ii.  public static double average(double[] array).
        //iii.Write main and invoke the 2 methods.
        public static int Average(int[] array)
        {
            int sum = 0;
            for(int i=0; i<array.Length; i++)
            { sum += array[i]; }
            int Average = sum / array.Length;
            return Average;
        }

        public static double Average(double[] array)
        {
            double sum = 0;
            for(int i  = 0; i<array.Length;i++)
                sum =sum + array[i];
            double Average1 = sum / array.Length;
            return Average1;
        }
        static void Main(string[] args)
        {
            int[] numbers = new int[10] {1,2,3,6,5,4,7,8,9,8};
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Average of Array is:");
            Console.WriteLine(numbers.Average());

            double[] numbers2 = new double[10] { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7, 8.8, 9.9, 10.10 };
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Static Double Average is:");
            Console.WriteLine(numbers2.Average());

        }

        

        

    }
}
