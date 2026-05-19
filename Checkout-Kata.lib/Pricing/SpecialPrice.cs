namespace Checkout_Kata.lib.Pricing
{
    internal class SpecialPrice
    {
        public SpecialPrice(int quantity, int price) 
        {
            Quantity = quantity;
            Price = price;
        }
        public int Quantity { get; }
        public int Price { get; }
    }
}