using Microsoft.VisualStudio.TestTools.UnitTesting;
using SalesTax.Billing;
using SalesTax.ProductFactories;
using SalesTax.Products;
using SalesTax.Shopping;
using SalesTax.TaxCalculation;
using System.Collections.Generic;

namespace SalesTaxUnitTesting
{
    [TestClass]
    public class SalesTaxTestCases
    {
        [TestMethod]
        public void TestCase1_CalculateSalesTax()
        {
            ShoppingCart shoppingCartObj = new ShoppingCart();

            StoreShelf storeShelf = new StoreShelf();
            Product p1 = storeShelf.SearchAndRetrieveItemFromShelf("book", 12.49, false, 1);
            Product p2 = storeShelf.SearchAndRetrieveItemFromShelf("music cd", 14.99, false, 1);
            Product p3 = storeShelf.SearchAndRetrieveItemFromShelf("box of chocolates", 0.85, false, 1);

            shoppingCartObj.AddItemToCart(p1);
            shoppingCartObj.AddItemToCart(p2);
            shoppingCartObj.AddItemToCart(p3);

            List<Product> productList = shoppingCartObj.GetItemsFromCart();
            ITaxCalculator taxCalculatorObj = new TaxCalculator();
            Biller biller = new Biller(taxCalculatorObj);

            biller.CalcSalesTax(productList);

            double totalTax = biller.CalcTotalTax(productList);
            double totalAmount = biller.CalcTotalAmount(productList);

            Assert.AreEqual(1.50d, totalTax);
            Assert.AreEqual(29.83d, totalAmount);

        }

        [TestMethod]
        public void TestCase2_CalculateSalesTax()
        {
            ShoppingCart shoppingCartObj = new ShoppingCart();

            StoreShelf storeShelf = new StoreShelf();
            Product p1 = storeShelf.SearchAndRetrieveItemFromShelf("box of chocolates", 10.00, true, 1);
            Product p2 = storeShelf.SearchAndRetrieveItemFromShelf("bottle of perfume", 47.50, true, 1);

            shoppingCartObj.AddItemToCart(p1);
            shoppingCartObj.AddItemToCart(p2);

            List<Product> productList = shoppingCartObj.GetItemsFromCart();
            ITaxCalculator taxCalculatorObj = new TaxCalculator();
            Biller biller = new Biller(taxCalculatorObj);

            biller.CalcSalesTax(productList);

            double totalTax = biller.CalcTotalTax(productList);
            double totalAmount = biller.CalcTotalAmount(productList);

            Assert.AreEqual(7.65d, totalTax);
            Assert.AreEqual(65.15d, totalAmount);
        }

        [TestMethod]
        public void TestCase3_CalculateSalesTax()
        {
            ShoppingCart shoppingCartObj = new ShoppingCart();

            StoreShelf storeShelf = new StoreShelf();
            Product p1 = storeShelf.SearchAndRetrieveItemFromShelf("bottle of perfume", 27.99, true, 1);
            Product p2 = storeShelf.SearchAndRetrieveItemFromShelf("bottle of perfume", 18.99, false, 1);
            Product p3 = storeShelf.SearchAndRetrieveItemFromShelf("packet of headache pills", 9.75, false, 1);
            Product p4 = storeShelf.SearchAndRetrieveItemFromShelf("box of chocolates", 11.25, true, 1);

            shoppingCartObj.AddItemToCart(p1);
            shoppingCartObj.AddItemToCart(p2);
            shoppingCartObj.AddItemToCart(p3);
            shoppingCartObj.AddItemToCart(p4);

            List<Product> productList = shoppingCartObj.GetItemsFromCart();
            ITaxCalculator taxCalculatorObj = new TaxCalculator();
            Biller biller = new Biller(taxCalculatorObj);

            biller.CalcSalesTax(productList);

            double totalTax = biller.CalcTotalTax(productList);
            double totalAmount = biller.CalcTotalAmount(productList);

            Assert.AreEqual(6.65d, totalTax);
            Assert.AreEqual(74.63d, totalAmount);
        }

        [TestMethod]
        public void IsBookFactoryCreateBookProduct()
        {
            ProductFactory pFactory = new BookFactory();
            Product book = pFactory.CreateProduct("book", 20, 2, true);

            Assert.IsNotNull(book);
            Assert.IsInstanceOfType(book, typeof(BookProduct));           
        }
    }
}
