namespace Checkout_Kata.lib.Pricing
{
    internal class ItemPrice
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
    }
}
