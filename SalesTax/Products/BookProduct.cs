using System;
using System.Collections.Generic;
using System.Text;
using SalesTax.ProductFactories;
using SalesTax.Billing;

namespace SalesTax.Products
{
    public class BookProduct : Product
    {
        public BookProduct()
        {
        }

        public BookProduct(
            ProductAttributes productAttributes) 
            : base(productAttributes)
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
