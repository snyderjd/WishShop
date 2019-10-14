using System;

namespace WishShop
{
    public class Wish : Object
    {
        public string Text { get; }
        public int Price { get; protected set; }
        protected int _successPercentage = 90;

        public Wish(string text)
        {
            Text = text;
            Price = 10_000;
        }

        public override string ToString()
        {
            return $"The wish is {Text}. It costs {Price}";
        }

        public virtual bool MakeWish(User user)
        {
            if (user.Money < Price)
            {
                throw new Exception("You don't have enough money to make this wish");
            }

            user.Money -= Price;

            bool isWishSuccessful = CalculateSuccess();

            Console.WriteLine("---------");
            if (isWishSuccessful)
            {
                Console.WriteLine($"  Your Wish, '{Text},` was successful!");
            }
            else
            {
                Console.WriteLine($"  Sorry, your Wish, '{Text},` was didn't work out.!");
            }
            Console.WriteLine("---------");

            return isWishSuccessful;
        }

        private bool CalculateSuccess()
        {
            return new Random().Next(1, 101) < _successPercentage;
        }
    }
}