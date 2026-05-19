using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkout_Kata.lib.Exceptions
{
    internal class PriceListIsEmptyException : Exception
    {
        public PriceListIsEmptyException() : base("Price list cannot be empty") { }
    }
}
