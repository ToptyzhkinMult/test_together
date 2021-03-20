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
            Console.WriteLine("Введите первое число: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите знак операции: + Сложение  - Вычитание  * Умножение / Деление" );

            var operation = Console.ReadKey().KeyChar;
            double result = 0;
            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    Console.WriteLine($"Результат операции {result}");
                    break;
                case '-':
                    result = num1 - num2;
                    Console.WriteLine($"Результат операции {result}");
                    break;
                case '*':
                    result = num1 * num2;
                    Console.WriteLine($"Результат операции {result}");
                    break;
                case '/':
                    result = num1 / num2;
                    Console.WriteLine($"Результат операции {result}");
                    break;
                default:
                    Console.WriteLine("Неизвестная операция");
                    break;

            }
            Console.ReadKey();

        }
    }
}
