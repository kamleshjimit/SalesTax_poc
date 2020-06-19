using SalesTax.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesTax.ProductFactories;

namespace SalesTax.Shopping
{
    public class StoreShelf
    {
        private readonly Dictionary<string, Product> productItems;

        public object BookFacotry { get; private set; }

        public StoreShelf()
        {
            productItems = new Dictionary<string, Product>();
            AddProductItemsToShelf("book", new BookProduct());
            AddProductItemsToShelf("music cd", new MiscellaneousProduct());
            AddProductItemsToShelf("chocolate bar", new FoodProduct());
            AddProductItemsToShelf("box of chocolates", new FoodProduct());
            AddProductItemsToShelf("bottle of perfume", new MiscellaneousProduct());
            AddProductItemsToShelf("packet of headache pills", new MedicalProduct());
        }

        public void AddProductItemsToShelf(String productItem, Product productCategory)
        {
            productItems.Add(productItem, productCategory);
        }

        public Product SearchAndRetrieveItemFromShelf(String name, double price, bool imported, int quantity)
        {
            if (productItems.ContainsKey(name))
            {
                ProductAttributes pAttributes = new ProductAttributes(name, price, quantity, imported);
                Product productItem = productItems[name].GetFactory().CreateProduct(pAttributes);
                return productItem;
            }
            else
            {
                Console.WriteLine("Product not available, pls enter another product \n");
                return null;
            }
        }

        public int GetShelfSize()
        {
            return productItems.Count;
        }
    }
}
