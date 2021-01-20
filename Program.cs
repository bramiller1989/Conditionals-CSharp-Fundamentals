using System;

namespace Conditionals
{
    class Program
    {
        public enum Season
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }

        static void Main(string[] args)
        {
            int hour = 10;
            bool isGoldCustomer = true;
            float price;

            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It's morning.");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("It's afternoon.");
            }
            else
            {
                Console.WriteLine("It's evening.");
            }

            price = (isGoldCustomer) ? 19.95f : 29.95f;

            Console.WriteLine(price);
        }
    }
}
