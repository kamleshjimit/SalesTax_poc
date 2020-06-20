using System;
using System.Collections.Generic;
using System.Text;

namespace SalesTax.Products
{
    public class ProductAttributes
    {
        public string Name { get; set; }

        public double Price { get; set; }

        public int Quantity { get; set; }

        public bool IsImported { get; set; }

        public double SalesTax { get; set; }

        public ProductAttributes(string name, double price, int quantity, bool isImported)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            IsImported = isImported;
            //SalesTax = tax;
        }
    }
}
