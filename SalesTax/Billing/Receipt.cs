using SalesTax.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTax.Billing
{
    /// <summary>
    /// Receipt will generate receipt based on product data.
    /// </summary>
    public class Receipt
    {
        private List<Product> ProductList { get; set; }
        private double TotalSalesTax { get; set; }
        private double TotalAmount { get; set; }

        public Receipt(List<Product> prod, double tSalestax, double tAmount)
        {
            ProductList = prod;
            TotalSalesTax = tSalestax;
            TotalAmount = tAmount;
        }

        public int GetTotalNumberOfItems()
        {
            return ProductList.Count;
        }

        public override string ToString()
        {
            StringBuilder receipt = new StringBuilder();
            Console.WriteLine("***************");
            foreach (var p in ProductList)
            {
                receipt.Append((p.ToString() + "\n"));
            }

            receipt.Append("Total sales tax : " + TotalSalesTax + "    ");
            receipt.Append("Total amount : " + TotalAmount + "\n");

            return receipt.ToString();
        }
    }
}
