using System;

namespace WishShop
{
    public class DiscountWish : Wish
    {
        public DiscountWish(string text) : base(text)
        {
            Price = 1_000;
            _successPercentage = 50;
        }

        public void IncreaseSuccessPct() {
            _successPercentage += 10;
            Price += 1_000;
        }

        public override bool MakeWish(User user)
        {
            Console.WriteLine("--- Discount Wish ---");
            return base.MakeWish(user);
        }
    }
}