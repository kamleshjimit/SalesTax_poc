using System;
using System.Collections.Generic;
using System.Text;
using SalesTax.ProductFactories;
using SalesTax.Billing;

namespace SalesTax.Products
{
    public class MiscellaneousProduct : Product
    {
        public MiscellaneousProduct()
        {
        }

        public MiscellaneousProduct(ProductAttributes productAttribute) 
            : base(productAttribute)
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
