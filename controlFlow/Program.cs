using System;

namespace controlFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            var hour = 14;

            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It's Morning!!");
            }
            else if (hour >= 12 && hour <= 18)
            {
                Console.WriteLine("It's Afternoon Lunch Break!! hoo!!");
            }
            else
            {
                Console.WriteLine("It's Evening let's Go Home Safely!!");
            }

        /*
            bool isGoldCustomer = true;

            float price = (isGoldCustomer) ? 19.95f : 29.95f;
            Console.WriteLine(price);  */

        }
    }
}