using System;
using System.Collections.Generic;
using System.Text;
using SalesTax.TaxCalculation;
using SalesTax.ProductFactories;

namespace SalesTax.Products
{
    public class MiscellaneousProduct : Product
    {
        public MiscellaneousProduct()
        {
        }

        public MiscellaneousProduct(
            string name, double price, int quantity, bool isImported) 
            : base(name, price, quantity, isImported)
        {
        }

        
        public override ProductFactory GetFactory()
        {
            return new MiscellaneousFactory();
        }

        public override double GetTaxValue()
        {
            return LocalTaxValues.MISC_TAX;
        }
    }
}
