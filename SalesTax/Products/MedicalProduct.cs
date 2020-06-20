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
            ProductAttributes productAttributes) 
            : base(productAttributes)
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
