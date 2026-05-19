namespace Checkout_Kata.lib.Pricing
{
    internal static class PriceConstants
    {
        public static List<ItemPrice> ItemPrices { get; } = new List<ItemPrice>
        {
            new ItemPrice("A", 50, new SpecialPrice(quantity: 3, price: 130)),
            new ItemPrice("B", 30, new SpecialPrice(quantity: 2, price: 45)),
            new ItemPrice("C", 20, null),
            new ItemPrice("D", 15, null) 
        };
    }
}
