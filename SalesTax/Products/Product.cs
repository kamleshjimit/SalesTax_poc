using System;
using System.Collections.Generic;
using System.Text;
using SalesTax.ProductFactories;

namespace SalesTax.Products
{
    public abstract class Product
    {
        public ProductAttributes PAttributes { get; set; }

        public Product()
        {
        }

        public Product(ProductAttributes pAttributes)
        {
            PAttributes = pAttributes;
        }

        public override string ToString()
        {
            double totalProductPrice = (PAttributes.Price + PAttributes.SalesTax ) * PAttributes.Quantity;
            return (PAttributes.Quantity + " " + ImportedToString(PAttributes.IsImported) + " "
                + PAttributes.Name + " : " + totalProductPrice);
        }

        public string ImportedToString(bool imported)
        {
            if (!imported)
                return string.Empty;
            else
                return "imported";
        }

        public abstract double GetTaxValue();


        public abstract ProductFactory GetFactory();


    }
}
