using System;
using System.Collections.Generic;
using System.Text;
using SalesTax.ProductFactories;

namespace SalesTax.Products
{
    public abstract class Product
    {
        public string Name { get; set; }

        public double Price { get; set; }

        public int Quantity { get; set; }

        public bool IsImported { get; set; }
        
        public double SalesTax { get; set; }

      
        public Product()
        {
            Name = string.Empty;
            Price = 0;
            Quantity = 1;
            IsImported = true;
            SalesTax = 0;
        }

        public Product(
            string name, double price, int quantity, bool isImported)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            IsImported = isImported;
        }

        public override string ToString()
        {
            double totalProductPrice = Price * Quantity + SalesTax;
            return (Quantity + " " + ImportedToString(IsImported) + " " + Name + " : " + totalProductPrice);
        }

        public String ImportedToString(bool imported)
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
