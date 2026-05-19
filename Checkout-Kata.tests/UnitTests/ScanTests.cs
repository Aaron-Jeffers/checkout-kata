using Checkout_Kata.lib;
using Checkout_Kata.lib.Exceptions;
using Checkout_Kata.tests.Constants;

namespace Checkout_Kata.tests.UnitTests
{
    public class ScanTests
    {
        [Fact]
        public void ScanningAnNullStringShouldThrowException()
        {
            Checkout checkout = new Checkout(PriceConstants.ItemPrices);

            Assert.Throws<StringIsNullEmptyOrWhiteSpaceException>(() => checkout.Scan(null));
        }

        [Fact]
        public void ScanningAnEmptyStringShouldThrowException()
        {
            Checkout checkout = new Checkout(PriceConstants.ItemPrices);

            Assert.Throws<StringIsNullEmptyOrWhiteSpaceException>(() => checkout.Scan(string.Empty));
        }

        [Fact]
        public void ScanningAWhiteSpaceStringShouldThrowException()
        {
            Checkout checkout = new Checkout(PriceConstants.ItemPrices);

            Assert.Throws<StringIsNullEmptyOrWhiteSpaceException>(() => checkout.Scan("  "));
        }

        [Fact]
        public void ScanningAnItemThatDoesNotExistShouldThrowException()
        {
            Checkout checkout = new Checkout(PriceConstants.ItemPrices);
            Assert.Throws<ItemNotFoundException>(() => checkout.Scan("E"));
        }
    }
}