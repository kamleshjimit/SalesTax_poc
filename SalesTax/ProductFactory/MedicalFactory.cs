using System;
using System.Collections.Generic;
using System.Text;
using SalesTax.Products;

namespace SalesTax.ProductFactories
{
    public class MedicalFactory : ProductFactory
    {
        public override Product CreateProduct(
            string name, double price, int quantity, bool IsImported)
        {
            return new MedicalProduct(name, price, quantity, IsImported);
        }
    }
}
