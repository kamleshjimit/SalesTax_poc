using System;
using System.Collections.Generic;
using System.Text;

namespace SalesTax.TaxCalculation
{
    public interface ITaxCalculator
    {
        double CalculateTax(
            double price, bool IsImported, double basicTaxPercentage);
    }
}
