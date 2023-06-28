using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Darray
{
    internal class program9
    {
        //  WAP to count frequency of each element in an array.
        static void Main(string[] args)
        {
            int i, j, count, num;

            int[] arr = new int[100];
            int[] frequency = new int[100];

            //Reads size of the array
            Console.WriteLine("Enter size of the array: ");
            num = Convert.ToInt32(Console.ReadLine());

            //Reads elements in array
            Console.WriteLine("Enter elements in the array: ");
            for (i = 0; i < num; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                //Initially initialize frequency variable to -1
                frequency[i] = -1;
            }


            for (i = 0; i < num; i++)
            {
                count = 1;
                for (j = i + 1; j < num; j++)
                {
                    //If duplicate element is found
                    if (arr[i] == arr[j])
                    {
                        count++;

                        //Make sure not to count frequency of same element again
                        frequency[j] = 0;
                    }
                }

                //If frequency of current element is not counted
                if (frequency[i] != 0)
                {
                    frequency[i] = count;
                }
            }


            //Print frequency of each element
            Console.WriteLine("\nFrequency of all elements of array : \n");
            for (i = 0; i < num; i++)
            {
                if (frequency[i] != 0)
                {
                    Console.WriteLine(arr[i] + " occurs " + frequency[i] + " times");
                }
            }


            Console.ReadLine();
        }
    }
}

        

            