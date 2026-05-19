using Checkout_Kata.lib.Exceptions;
using Checkout_Kata.lib.Pricing;

namespace Checkout_Kata.lib
{
    public class Checkout : ICheckout
    {
        private List<ItemPrice> ItemPrices { get; }
        private Dictionary<ItemPrice, int> ScannedItems { get; set; }

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
            ScannedItems = new Dictionary<ItemPrice, int>();
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

            var key = ItemPrices.First(i => i.SKU == item);

            if (!ScannedItems.TryAdd(key, 1))
            {
                ScannedItems[key]++;
            }
        }

        public int GetTotalPrice()
        {
            int price = 0;

            foreach (var kvp in ScannedItems)
            {
                var itemPrice = kvp.Key;
                var count = kvp.Value;

                price += itemPrice.CalculatePrice(count);
            }

            return price;
        }
    }
}
