using System;
using System.Collections.Generic;
using System.Text;
using SalesTax.ProductFactories;
using SalesTax.Billing;

namespace SalesTax.Products
{
    public class FoodProduct : Product
    {
        public FoodProduct()
        {
        }

        public FoodProduct(
            ProductAttributes productAttributes) 
            : base(productAttributes)
        {
        }

        
        public override ProductFactory GetFactory()
        {
            return new FoodFactory();
        }

        public override double GetTaxValue()
        {
            return LocalTaxValues.FOOD_TAX;
        }
    }
}
