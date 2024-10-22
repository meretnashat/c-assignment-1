using System;

namespace day_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lab Assignments day1:
            #region 1-birthday
            Console.WriteLine("plz enter your year from 1980->2023");
            int Byear = int.Parse(Console.ReadLine());
            Console.WriteLine("plz enter your month 1-12");
            int Bmonth = int.Parse(Console.ReadLine());
            Console.WriteLine("plz enter your day");
            int Bday = int.Parse(Console.ReadLine());

            int currentday = 22;
            int currentmonth = 10;
            int currentyear = 2024;

            bool IsLeapYear(int year)
            {
                return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
            }

            // Function to calculate the number of days in a given month of a year
            int DaysInMonth(int year, int month)
            {
                if (month == 2) // February
                {
                    return IsLeapYear(year) ? 29 : 28;
                }
                else if (month == 4 || month == 6 || month == 9 || month == 11) // April, June, September, November
                {
                    return 30;
                }
                else // January, March, May, July, August, October, December
                {
                    return 31;
                }
            }

            // Calculate years, months, and days
            int years = currentyear - Byear;
            int months = currentmonth - Bmonth;
            int days = currentday - Bday;

            // Adjust months and days if necessary
            if (days < 0)
            {
                months--;
                days += DaysInMonth(currentyear, (currentmonth - 1 + 12) % 12); // previous month
            }

            if (months < 0)
            {
                years--;
                months += 12;
            }

            // Output result
            Console.WriteLine($"You are {years} years, {months} months, and {days} days old.");
            #endregion

            #region 2-Calc

            do
            {
                char con;
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
                Console.WriteLine("Continue ??? y or n : ");

                while (con
                    == 'y') ;
                {
                    Console.WriteLine("Program closed. Goodbye!");
                }

                #endregion

            #region 3-1d array

                #endregion

            #region 4- 2d array

                #endregion

            }
    }
            
}   