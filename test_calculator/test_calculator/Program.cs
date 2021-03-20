using System;

namespace test_calculator
{
    class Program
    {


        static double Addition(double a, double b)
        {
            double c= a + b;
            return c;
        }

        static double Substraction(double a, double b)
        {
            double c = a - b;
            return c;
        }

        static double Multiplication(double a, double b)
        {
            double c = a * b;
            return c;
        }

        static double Division(double a, double b)
        {
            double c = a / b;
            return c;
        }
            static void Main(string[] args)
            {
                Console.WriteLine("Введите первое число: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

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
