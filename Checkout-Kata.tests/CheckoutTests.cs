using Checkout_Kata.lib;
using Checkout_Kata.lib.Exceptions;
using Xunit;
namespace Checkout_Kata.tests
{
    public class CheckoutTests
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
    }
}