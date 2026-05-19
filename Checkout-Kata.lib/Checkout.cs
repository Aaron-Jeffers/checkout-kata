using Checkout_Kata.lib.Exceptions;
using Checkout_Kata.lib.Pricing;

namespace Checkout_Kata.lib
{
    public class Checkout : ICheckout
    {
        private List<ItemPrice> ItemPrices { get; }
        private List<string> ScannedItems { get; set; } = new List<string>();

        public Checkout(List<ItemPrice> itemPrices)
        {
            if (itemPrices == null)
            {
                throw new ArgumentNullException(nameof(List<ItemPrice>));
            }
            if (!itemPrices.Any())
            {
                throw new PriceListIsEmptyException();
            }
            ItemPrices = itemPrices;
            ScannedItems = new List<string>();
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

            ScannedItems.Add(item);
        }

        public int GetTotalPrice()
        {
            throw new NotImplementedException();
        }
    }
}
