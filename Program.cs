using System;

namespace WishShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Wish Shop");
            Console.WriteLine("------------------------");

            User aUser = new User();
            aUser.Money = 200_000;

            Console.Write("Your name? ");
            aUser.Name = Console.ReadLine();

            Console.Write("Your Wish? ");
            string wishText = Console.ReadLine();
            while (!string.IsNullOrWhiteSpace(wishText))
            {
                Wish aWish = new Wish(wishText);
                if (aWish.MakeWish(aUser))
                {
                    Console.WriteLine("Yay!");
                }
                else
                {
                    Console.WriteLine("Boo!");
                }
                Console.WriteLine($"You have ${aUser.Money} left.");

                Console.WriteLine();
                Console.WriteLine();
                Console.Write("Your Wish? ");
                wishText = Console.ReadLine();
            }

            Console.WriteLine("Thanks for stopping by the Wish Shop!");
        }
    }
}
