using SalesTax.TaxCalculation;
using System;
using System.Collections.Generic;
using System.Text;
using SalesTax.Products;

namespace SalesTax.ProductFactories
{
    public abstract class ProductFactory
    {
        public abstract Product CreateProduct(
            string name, double price, int quantity, bool IsImported);
    }
}
