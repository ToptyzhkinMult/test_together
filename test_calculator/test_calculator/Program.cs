using System;

namespace test_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int d = Addition(5, 3);
            Console.WriteLine($"{d}");
        }

        static int Addition(int a, int b)
        {
            int c= a + b;
            return c;
        }

        static int Substraction(int a, int b)
        {
            int c = a - b;
            return c;
        }

        static int Multiplication(int a, int b)
        {
            int c = a * b;
            return c;
        }

        static int Division(int a, int b)
        {
            int c = a / b;
            return c;
        }
    }
}
