using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageMarkStudents
{
    class Program2
    {

        static void Main(string[] args)
        {

            int  m1, m2, m3, total;
            
            float average;
            string n;

            Console.WriteLine("Enter Student Name :");
            n = Console.ReadLine();

            Console.WriteLine("Enter Subject1 Marks : ");
            m1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Subject2 Marks : ");
            m2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Subject3 Marks :");
            m3 = Convert.ToInt32(Console.ReadLine());

            
            total = m1 + m2 + m3;

           
            average = total / 3;

            
            Console.WriteLine("Final result of {0} is:", n);
            Console.WriteLine("Total Marks : " + total);
            Console.WriteLine("Average : " + average);

            if (average <= 35)
            {
                Console.WriteLine("Grade is F");
            }
            else if (average >= 34 && average <= 39)
            {
                Console.WriteLine("Grade is D");
            }
            else if (average >= 40 && average <= 59)
            {
                Console.WriteLine("Grade is C");
            }
            else if (average >= 60 && average <= 69)
            {
                Console.WriteLine("Grade is B");
            }
            else if (average >= 70 && average <= 79)
            {
                Console.WriteLine("Grade is B+");
            }
            else if (average >= 80 && average <= 90)
            {
                Console.WriteLine("Grade is A");
            }
            else if (average >= 91)
            {
                Console.WriteLine("Grade is A+");
            }
        }
    }

}
