using System;
using System.Collections.Generic;
using System.Text;

namespace SalesTax.Billing
{
    public class TaxCalculator : ITaxCalculator
    {
        public double CalculateTax(
            double price, bool IsImported, double LocalTax)
        {
            
            double tax = price * LocalTax;

            if (IsImported)
            {
                tax = tax + price * 0.05;
            }
            tax = RoundOff(tax); 
            return tax;

        }

        private const double ROUND_OFF = 0.05;

        private double RoundOff(double value)
        {
            return (int)(value / ROUND_OFF + 0.5) * 0.05;
        }
    }
}
