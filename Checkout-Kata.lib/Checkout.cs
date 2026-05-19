using Checkout_Kata.lib.Exceptions;
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
            if (string.IsNullOrWhiteSpace(item))
            {
                throw new StringIsNullEmptyOrWhiteSpaceException();
            }
            if (!ItemPrices.Any(i => i.SKU == item))
            {
                throw new ItemNotFoundException(item);
            }
        }

        public int GetTotalPrice()
        {
            throw new NotImplementedException();
        }
    }
}
