using System;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = 10;
            bool isGoldCustomer = true;
            float price;
            var season = Season.Autumn;

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

            switch (season)
            {
                case Season.Autumn:
                case Season.Summer:
                    Console.WriteLine("We've got promotion");
                    break;


                default:
                    Console.WriteLine("I don't understand that season!");
                    break;
            }

        }
    }
}
