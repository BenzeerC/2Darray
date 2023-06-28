using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Darray
{
    internal class program10
    {
        //WAP to merge 2 arrays to 3rd array. 3rd array should not have elements of same value.
        static void Main(string[] args)
        {
            int[] array1 = new int[5];
            int[] array2 = new int[5];
            int[] array3 = new int[array1.Length + array2.Length];
            Console.WriteLine("Enter Any 5 Elements for the First Array :");
            for (int i = 0; i < 5; i++)
            {
                array1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter Any 5 Elements for the Second Array :");
            for (int i = 0; i < 5; i++)
            {
                array2[i] = int.Parse(Console.ReadLine());
            }
            Buffer.BlockCopy(array1, 0, array3, 0, array1.Length * sizeof(int));
            Buffer.BlockCopy(array2, 0, array3, array1.Length * sizeof(int),
                             array2.Length * sizeof(int));
            Console.WriteLine("Elements in the Third Array After Appending" +
                              " First and Second Arrays :");
            foreach (int value in array3)
            {
                Console.WriteLine(value);
            }
            Console.ReadLine();
        }
    }
}

