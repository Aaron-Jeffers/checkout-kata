namespace Checkout_Kata.lib.Exceptions
{
    internal class ItemNotFoundException : Exception
    {
        internal ItemNotFoundException(string message) : base($"Item with SKU '{message}' not found in price list.")
        { }
        
        
    }
}
