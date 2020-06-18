using SalesTax.Products;
using SalesTax.TaxCalculation;
using SalesTax.Billing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTax.Shopping
{
    public class ShoppingStore
    {
        private ShoppingCart shoppingCartObj;
        private ITaxCalculator taxCalculatorObj;
        private Biller biller;

        public ShoppingStore()
        {
            shoppingCartObj = new ShoppingCart();
            taxCalculatorObj = new TaxCalculator();
            biller = new Biller(taxCalculatorObj);
        }

        private void RetrieveOrderAndPlaceInCart(String name, double price, bool imported, int quantity)
        {
            StoreShelf storeShelf = new StoreShelf();
            Product product = storeShelf.SearchAndRetrieveItemFromShelf(name, price, imported, quantity);
                      
            if(product != null)
                shoppingCartObj.AddItemToCart(product);
        }

        public void GetSalesOrder()
        {
            do
            {
                String name = GetProductName();
                double price = GetProductPrice();
                bool imported = IsProductImported();
                int quantity = GetQuantity();
                RetrieveOrderAndPlaceInCart(name, price, imported, quantity);
            }
            while (IsAddAnotherProduct());
        }

        public void CheckOutAndPrintReceipt()
        {
            List<Product> productList = shoppingCartObj.GetItemsFromCart();

            biller.CalcSalesTax(productList);

            double totalTax = biller.CalcTotalTax(productList);

            double totalAmount = biller.CalcTotalAmount(productList);

            Receipt receipt = new Receipt(productList, totalTax, totalAmount);

            PrintReceipt(receipt);
        }

        public void PrintReceipt(Receipt receipt)
        {
            Console.WriteLine("\n" + receipt.ToString());
        }
              

         public String GetProductName()
        {
            Console.WriteLine("Enter the product name:\n");
            return Console.ReadLine();
        }

        public double GetProductPrice()
        {
            Console.WriteLine("Enter the product price:\n");
            var input = Console.ReadLine();
            double val;
            while (!(double.TryParse(input, out val)))
            {
                Console.WriteLine("Invalid price. Enter a number");
            }

            return val;
        }

        public bool IsProductImported()
        {
            Console.WriteLine("Is product imported or not?(Y/N)\n");
            var input = Console.ReadLine();
            bool isValid = false;
           
            if (input == "Y" || input == "y")
                return true;
            else
                return false;
        }

        public int GetQuantity()
        {
            Console.WriteLine("Enter the quantity:\n");
            var input = Console.ReadLine();
            int intVal;
            while (!(int.TryParse(input, out intVal)))
            {
                Console.WriteLine("Invalid input. Enter a integer");
            }
            return intVal;
        }

        public bool IsAddAnotherProduct()
        {
            Console.WriteLine("Do you want to add another Product?(Y/N)");

            var input = Console.ReadLine();
            if ((input == "Y" || input == "y"))
            {
                return true;
            }

            return false;
        }
    }
}
