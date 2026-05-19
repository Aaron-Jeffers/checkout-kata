namespace Checkout_Kata.lib
{
    internal interface ICheckout
    {
        void Scan(string item);
        int GetTotalPrice();
    }
}
