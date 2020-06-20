using System;
using System.Collections.Generic;
using System.Text;

namespace SalesTax.Billing
{
    public interface ITaxCalculator
    {
        double CalculateTax(
            double price, bool IsImported, double basicTaxPercentage);
    }
}
