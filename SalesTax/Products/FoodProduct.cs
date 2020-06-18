using System;
using System.Collections.Generic;
using System.Text;
using SalesTax.TaxCalculation;
using SalesTax.ProductFactories;

namespace SalesTax.Products
{
    public class FoodProduct : Product
    {
        public FoodProduct()
        {
        }

        public FoodProduct(
            string name, double price, int quantity, bool isImported) 
            : base(name, price, quantity, isImported)
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
