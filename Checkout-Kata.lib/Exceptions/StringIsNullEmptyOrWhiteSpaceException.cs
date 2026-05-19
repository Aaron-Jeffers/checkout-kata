namespace Checkout_Kata.lib.Exceptions
{
    public class StringIsNullEmptyOrWhiteSpaceException : Exception
    {
        public StringIsNullEmptyOrWhiteSpaceException() : base("Item string cannot be null, empty or whitespace.") { }
    }
}
