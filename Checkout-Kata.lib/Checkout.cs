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

        /// <summary>
        /// Scans an item by its SKU and adds it to the checkout. Validates that the item is not null, empty, or whitespace, and that it exists in the price list. If the item is valid, it updates the count of scanned items for that SKU.
        /// </summary>
        /// <param name="item"></param>
        /// <exception cref="StringIsNullEmptyOrWhiteSpaceException"></exception>
        /// <exception cref="ItemNotFoundException"></exception>
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

        /// <summary>
        /// 
        /// </summary>
        /// <returns>The total price for the sum of each scanned SKU with special pricing applied as appropriate</returns>
        public int GetTotalPrice()
        {
            return ScannedItems.Sum(item => item.Key.CalculatePrice(item.Value));
        }
    }
}
