using System;

namespace StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine()); // 145

            // 145 % 10 = 5
            // 145 - 5 = 140 / 10 = 14
            // 14 % 10 = 4
            // 14 - 4 = 10 / 10 = 1
            // 1 % 10 = 1
            int tempNum = number;
            string strNum = "";
            strNum += number; // "145"
            int sum = 0;

            for (int i = 0; i < strNum.Length; i++)
            {
                int currentDigit = tempNum % 10; // 5
                tempNum = (tempNum - currentDigit) / 10;
                // 5! = 1*2*3*4*5
                int factorial = 1;
                for (int k = 1; k <= currentDigit; k++)
                {
                    factorial *= k;
                }
                sum += factorial;
            }
            if (number == sum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
