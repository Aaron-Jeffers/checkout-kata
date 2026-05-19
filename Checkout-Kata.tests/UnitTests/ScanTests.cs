using Checkout_Kata.lib;
using Checkout_Kata.lib.Exceptions;
using Checkout_Kata.tests.Constants;

namespace Checkout_Kata.tests.UnitTests
{
    public class ScanTests
    {
        [Fact]
        public void Scan_ThrowsException_NullArgument()
        {
            Checkout checkout = new Checkout(PriceConstants.ItemPrices);

            Assert.Throws<StringIsNullEmptyOrWhiteSpaceException>(() => checkout.Scan(null));
        }

        [Fact]
        public void Scan_ThrowsException_EmptyString()
        {
            Checkout checkout = new Checkout(PriceConstants.ItemPrices);

            Assert.Throws<StringIsNullEmptyOrWhiteSpaceException>(() => checkout.Scan(string.Empty));
        }

        [Fact]
        public void Scan_ThrowsException_WhiteSpaceString()
        {
            Checkout checkout = new Checkout(PriceConstants.ItemPrices);

            Assert.Throws<StringIsNullEmptyOrWhiteSpaceException>(() => checkout.Scan("  "));
        }

        [Fact]
        public void Scan_ThrowsItemNotFoundException()
        {
            Checkout checkout = new Checkout(PriceConstants.ItemPrices);
            Assert.Throws<ItemNotFoundException>(() => checkout.Scan("E"));
        }
    }
}