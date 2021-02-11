using System;

namespace Vacantion
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleCounts = int.Parse(Console.ReadLine());
            string people = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();         
            double price = 0;
            
            if (dayOfWeek == "Friday")
            {
                if (people == "Students")
                {
                    price = 8.45 * peopleCounts;
                    if (peopleCounts >= 30)
                    {
                        price = price - (price * 0.15);
                    }
                }
                else if (people == "Business")
                {
                    price = 10.90 * peopleCounts;
                    if (peopleCounts >= 100)
                    {
                        price = price - (10 * 10.90);
                    }
                }
                else if (people == "Regular")
                {
                    price = 15 * peopleCounts;
                    if (peopleCounts >= 10 && peopleCounts <= 20)
                    {
                        price = price - (price * 0.05);
                    }
                }
            }
            if (dayOfWeek == "Saturday")
            {
                if (people == "Students")
                {
                    price = 9.80 * peopleCounts;
                    if (peopleCounts >= 30)
                    {
                        price = price - (price * 0.15);
                    }
                }
                else if (people == "Business")
                {
                    price = 15.60 * peopleCounts;
                    if (peopleCounts >= 100)
                    {
                        price = price - (10 * 15.60);
                    }
                }
                else if (people == "Regular")
                {
                    price = 20 * peopleCounts;
                    if (peopleCounts >= 10 && peopleCounts <= 20)
                    {
                        price = price - (price * 0.05);
                    }
                }
            }
            if (dayOfWeek == "Sunday")
            {
                if (people == "Students")
                {
                    price = 10.46 * peopleCounts;
                    if (peopleCounts >= 30)
                    {
                        price = price - (price * 0.15);
                    }
                }
                else if (people == "Business")
                {
                    price = 16 * peopleCounts;
                    if (peopleCounts >= 100)
                    {
                        price = price - (10 * 16);
                    }
                }
                else if (people == "Regular")
                {
                    price = 22.50 * peopleCounts;
                    if (peopleCounts >= 10 && peopleCounts <= 20)
                    {
                        price = price - (price * 0.05);
                    }
                }
            }
            Console.WriteLine($"Total price: {price:F2}");
        }
    }
}
