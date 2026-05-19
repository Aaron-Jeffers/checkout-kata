namespace Checkout_Kata.lib.Exceptions
{
    internal class StringIsNullEmptyOrWhiteSpaceException : Exception
    {
        internal StringIsNullEmptyOrWhiteSpaceException() : base("Item string cannot be null, empty or whitespace.") { }
    }
}
