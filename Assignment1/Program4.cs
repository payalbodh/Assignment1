using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class Program4
    {
        static void SwapNum(ref int x, ref int y)
        {
            int t = x;
            x = y;
            y = t;
        }
        static void Main(string[] args)
        {
            int a = 100;
            int b = 500;

            Console.WriteLine("Value of a and b before swapping");
            Console.WriteLine("a=" + " " + a);
            Console.WriteLine("b=" + " " + b);
            SwapNum(ref a, ref b);
            Console.WriteLine();
            Console.WriteLine("Value of a and b after swapping");
            Console.WriteLine("a=" + " " + a);
            Console.WriteLine("b=" + " " + b);
            Console.ReadLine();
        }
    }
}
