﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _2Darray
{
    internal class program4
    {
        // WAP to put even and odd elements of array in two separate arrays.

        static void Main(string[] args)
        {
            int[] arr1 = new int[10];
            int[] arr2 = new int[10];
            int[] arr3 = new int[10];
            int i, j = 0, k = 0, n;

            Console.WriteLine("\nSeparate Odd and even integers in separate arrays.\n");
            Console.WriteLine("------------------------------------------------------\n");

            Console.WriteLine("Enter no of elements:");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input {0} elements in the array:",n);
            for(i=0; i<n; i++)
            {
                Console.WriteLine("element - {0}",i);
                arr1[i]= Convert.ToInt32(Console.ReadLine());
            }

            for(i=0;i<n; i++)
            {
                if (arr1[i]%2 ==0)
                {
                    arr2[j] = arr1[i];
                    j++;
                }
                else
                {
                    arr3[k] = arr1[i];
                    k++;
                }
                Console.Write("\nThe Even elements are : \n");
                for (i = 0; i < j; i++)
                {
                    Console.Write("{0} ", arr2[i]);
                }

                Console.Write("\nThe Odd elements are :\n");
                for (i = 0; i < k; i++)
                {
                    Console.Write("{0} ", arr3[i]);
                }
                //Console.Write("\n\n");
            }
        }
        
    }
}
