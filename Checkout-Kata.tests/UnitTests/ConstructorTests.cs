using Checkout_Kata.lib;
using Checkout_Kata.lib.Exceptions;
using Checkout_Kata.lib.Pricing;

namespace Checkout_Kata.tests.UnitTests
{
    public class ConstructorTests
    {
        [Fact]
        public void Constructor_ThrowsNullArgumentException()
        {
            Assert.Throws<ArgumentNullException>(() => new Checkout(null));
        }
        [Fact]
        public void Constructor_ThrowsPriceListIsEmptyException()
        {
            Assert.Throws<PriceListIsEmptyException>(() => new Checkout(new List<ItemPrice>()));
        }
    }
}