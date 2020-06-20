using SalesTax.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTax.Billing
{
    public class Biller
    {
        ITaxCalculator taxCalculator;

        public Biller(ITaxCalculator taxCalc)
        {
            taxCalculator = taxCalc;
        }

        public void CalcSalesTax(List<Product> productList)
        {
            foreach (Product p in productList)
            {
                double productTax = taxCalculator.CalculateTax(
                    p.PAttributes.Price, p.PAttributes.IsImported, p.GetTaxValue());
                p.PAttributes.SalesTax = Truncate(productTax);
            }
        }
                
       public double CalcTotalTax(List<Product> productList)
        {
            double totalTax = 0.0;

            productList.ForEach(p => totalTax +=  p.PAttributes.SalesTax * p.PAttributes.Quantity);

            return Truncate(totalTax);
        }

        public double CalcTotalAmount(List<Product> prodList)
        {
            double totalAmount = 0.0;

            prodList.ForEach(p => totalAmount += 
            ((p.PAttributes.Price + p.PAttributes.SalesTax) * p.PAttributes.Quantity));

            return Truncate(totalAmount);
        }


        private double Truncate(double value)
        {
            String result = value.ToString("N2"); ;
            return Double.Parse(result);
        }

    }
}
