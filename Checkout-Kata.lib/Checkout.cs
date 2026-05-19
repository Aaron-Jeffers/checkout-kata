using Checkout_Kata.lib.Pricing;

namespace Checkout_Kata.lib
{
    public class Checkout : ICheckout
    {
        private List<ItemPrice> ItemPrices { get; }

        public Checkout(List<ItemPrice> itemPrices)
        {
            ItemPrices = itemPrices;
        }
        public void Scan(string item)
        {
            throw new NotImplementedException();
        }

        public int GetTotalPrice()
        {
            throw new NotImplementedException();
        }
    }
}
