using System;
using System.Collections.Generic;
using System.Text;
using SalesTax.ProductFactories;
using SalesTax.Billing;

namespace SalesTax.Products
{
    public class MedicalProduct : Product
    {
        public MedicalProduct()
        {
        }

        public MedicalProduct(
            string name, double price, int quantity, bool isImported) 
            : base(name, price, quantity, isImported)
        {
        }

        
        public override ProductFactory GetFactory()
        {
            return new MedicalFactory();
        }

        public override double GetTaxValue()
        {
            return LocalTaxValues.MEDICAL_TAX;
        }
    }
}
