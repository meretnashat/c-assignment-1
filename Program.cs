using System;

namespace challenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter 2 numbers: ");
            int num1 = Convert.ToInt16(Console.ReadLine());
            int num2 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Choose between (+, -, *, /): ");
            char op = Convert.ToChar(Console.ReadLine());

            switch (op)
            {
                case '+':
                    Console.WriteLine($"Result: {num1} + {num2} = {num1 + num2}");
                    break;

                case '-':
                    Console.WriteLine($"Result: {num1} - {num2} = {num1 - num2}");
                    break;

                case '*':
                    Console.WriteLine($"Result: {num1} * {num2} = {num1 * num2}");
                    break;

                case '/':
                    if (num2 != 0)
                    {
                        Console.WriteLine($"Result: {num1} / {num2} = {num1 / num2}");
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    }
                    break;

                default:
                    Console.WriteLine("Error: Invalid operation. Please choose +, -, *, or /.");
                    break;
            }
        }
        }
    }
