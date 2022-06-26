using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class Program3
    {
        static int sum(int[] arr, int n)
        {

            int sum = 0;
            for (int i = 0; i < n; i++)
                sum += arr[i];

            return sum;
        }

        public static void Main()
        {

            int[] a = { 1,2,3,4,5};
            int n = a.Length;

            Console.Write("Sum of given array is "
                                   + sum(a, n));
        }

    }
}
