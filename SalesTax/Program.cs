using System;
using SalesTax.Shopping;

namespace SalesTax
{
    class Program
    {
        static void Main(string[] args)
        {
            ShoppingStore shopping = new ShoppingStore();
            shopping.GetSalesOrder();
            shopping.CheckOutAndPrintReceipt();
        }
    }
}
