using Checkout_Kata.lib;
using Checkout_Kata.tests.Constants;

namespace Checkout_Kata.tests.UnitTests
{
    public class PricingTests
    {
        [Fact]
        public void GetTotalPrice_NoItems_ReturnZero()
        {
            Checkout checkout = new Checkout(PriceConstants.ItemPrices);
            int price = checkout.GetTotalPrice();

            Assert.Equal(0, price);
        }

        [Fact]
        public void GetTotalPrice_OneItem_CorrectPricing()
        {
            Checkout checkout = new Checkout(PriceConstants.ItemPrices);

            checkout.Scan("A"); //50 each

            int price = checkout.GetTotalPrice();

            Assert.Equal(50, price);
        }

        [Fact]
        public void GetTotalPrice_MultipleItems_CorrectPricing()
        {
            Checkout checkout = new Checkout(PriceConstants.ItemPrices);
            
            checkout.Scan("A"); //50 each, 3 for 130
            checkout.Scan("A"); //50 each, 3 for 130

            int expectedPrice = 100;
            int price = checkout.GetTotalPrice();

            Assert.Equal(expectedPrice, price);
        }

        [Fact]
        public void GetTotalPrice_OfferItems_CorrectPricing()
        {
            Checkout checkout = new Checkout(PriceConstants.ItemPrices);

            checkout.Scan("A"); //50 each, 3 for 130
            checkout.Scan("A"); //50 each, 3 for 130
            checkout.Scan("A"); //50 each, 3 for 130

            int expectedPrice = 130;
            int price = checkout.GetTotalPrice();

            Assert.Equal(expectedPrice, price);
        }

        [Fact]
        public void GetTotalPrice_MixedItemsAndOfferItems_CorrectPricing()
        {
            Checkout checkout = new Checkout(PriceConstants.ItemPrices);

            checkout.Scan("A"); //50 each, 3 for 130
            checkout.Scan("A"); //50 each, 3 for 130
            checkout.Scan("A"); //50 each, 3 for 130

            checkout.Scan("B"); //30 each, 2 for 45

            int expectedPrice = 130 + 30;
            int price = checkout.GetTotalPrice();

            Assert.Equal(expectedPrice, price);
        }

        [Fact]
        public void GetTotalPrice_ExampleCheckoutScenario_CorrectPricing()
        {
            Checkout checkout = new Checkout(PriceConstants.ItemPrices);

            checkout.Scan("B"); //30 each, 2 for 45

            checkout.Scan("A"); //50 each, 3 for 130

            checkout.Scan("B"); //30 each, 2 for 45

            int expectedPrice = 45 + 50;
            int price = checkout.GetTotalPrice();

            Assert.Equal(expectedPrice, price);
        }
    }
}
