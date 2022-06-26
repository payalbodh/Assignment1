using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class Program5
    {
        static double area(double r)
        {

            double PI = 3.14;
            double area = PI * r * r ;
            return area;
        }
        static double circumference(double r)
        {

            double PI = 3.14;
            double cir = 2 * PI * r;
            return cir;
        }

        public static void Main()
        {

            double r = 5;

            Console.WriteLine("Area = "
                                       + area(r));
            Console.WriteLine("Circumference = "
                                      + circumference(r));
        }
    }
}
