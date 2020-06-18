using System;
using System.Collections.Generic;
using System.Text;
using SalesTax.TaxCalculation;
using SalesTax.ProductFactories;

namespace SalesTax.Products
{
    public class BookProduct : Product
    {
        public BookProduct()
        {
        }

        public BookProduct(
            string name, double price, int quantity, bool isImported) 
            : base(name, price, quantity, isImported)
        {
        }

        
        public override ProductFactory GetFactory()
        {
            return new BookFactory();
        }

        public override double GetTaxValue()
        {
            return LocalTaxValues.BOOK_TAX;
        }
    }
}
