namespace Checkout_Kata.lib.Exceptions
{
    public class ItemNotFoundException : Exception
    {
        public ItemNotFoundException(string message) : base($"Item with SKU '{message}' not found in price list.")
        { }
        
        
    }
}
