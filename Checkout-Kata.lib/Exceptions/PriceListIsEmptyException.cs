namespace Checkout_Kata.lib.Exceptions
{
    public class PriceListIsEmptyException : Exception
    {
        public PriceListIsEmptyException() : base("Price list cannot be empty") { }
    }
}
