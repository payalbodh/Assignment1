using System;

namespace Assignment1
{
    class Program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press 1 for Addition");
            Console.WriteLine("Press 2 for Subtraction");
            Console.WriteLine("Press 3 for Multiplication");
            Console.WriteLine("Press 4 for Division \n");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 1st input");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd input");
            int n2 = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            switch (a)
            {
                case 1:
                    {
                        result = Addition(n1, n2);
                        break;
                    }
                case 2:
                    {
                        result = Subtraction(n1, n2);
                        break;
                    }
                case 3:
                    {
                        result = Multiplication(n1, n2);
                        break;
                    }
                case 4:
                    {
                        result = Division(n1, n2);
                        break;
                    }
                default:
                    Console.WriteLine("Please enter correct key");
                    break;
            }
            Console.WriteLine("The result is {0}", result);
            Console.ReadKey();
        }
        //Addition  
        public static int Addition(int n1, int n2)
        {
            int result = n1+n2;
            return result;
        }
        //Substraction  
        public static int Subtraction(int n1, int n2)
        {
            int result = n1 - n2;
            return result;
        }
        //Multiplication  
        public static int Multiplication(int n1, int n2)
        {
            int result = n1 * n2;
            return result;
        }
        //Division  
        public static int Division(int n1, int n2)
        {
            int result = n1 / n2;
            return result;
        }
    }
}
