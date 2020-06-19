using System;
using System.Collections.Generic;
using System.Text;
using SalesTax.Products;

namespace SalesTax.ProductFactories
{
    public class MiscellaneousFactory : ProductFactory
    {
        public override Product CreateProduct(
            string name, double price, int quantity, bool IsImported)
        {
            return new MiscellaneousProduct(name, price, quantity, IsImported);
        }
    }
}
