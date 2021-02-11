using System;

namespace Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int num1 = 0;
            if (number % 10 == 0)
            {
                num1 = 10;
            }
            else if (number % 7 == 0)
            {
                num1 = 7;
            }
            else if (number % 6 == 0)
            {
                num1 = 6;
            }
            else if (number % 3 == 0)
            {
                num1 = 3;
            }
            else if (number % 2 == 0)
            {
                num1 = 2;
            }
            if (num1 != 0)
            {
                Console.WriteLine($"The number is divisible by {num1}");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }
        }
    }
}
