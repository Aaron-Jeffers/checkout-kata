namespace Checkout_Kata.lib.Pricing
{
    public class ItemPrice
    {
        public ItemPrice(string sku, int unitPrice, SpecialPrice? specialPrice) 
        {
            SKU = sku;
            UnitPrice = unitPrice;
            SpecialPrice = specialPrice;
        }
        public string SKU { get; }

        public int UnitPrice { get; }

        public SpecialPrice? SpecialPrice { get; }
        public bool HasSpecialPrice => SpecialPrice != null && SpecialPrice.HasValue;

        /// <summary>
        /// Returns the total price for the given quantity of items, applying the special price if applicable.
        /// </summary>
        /// <param name="count">Number of items to calculate price for</param>
        /// <returns></returns>
        public int CalculatePrice(int count)
        {
            if (HasSpecialPrice && count >= SpecialPrice.Quantity)
            {
                int specialPriceCount = count / SpecialPrice.Quantity;
                int remainingItems = count % SpecialPrice.Quantity;
                return (specialPriceCount * SpecialPrice.Price) + (remainingItems * UnitPrice);
            }
            return count * UnitPrice;
        }
    }
}
