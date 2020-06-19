using System;
using System.Collections.Generic;
using System.Text;
using SalesTax.Products;

namespace SalesTax.ProductFactories
{
    public class BookFactory : ProductFactory
    {
        public override Product CreateProduct(ProductAttributes productAttributes)
        {
            return new BookProduct(productAttributes);
        }
    }
}
