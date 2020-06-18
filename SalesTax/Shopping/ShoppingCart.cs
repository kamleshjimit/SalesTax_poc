using System;
using System.Collections.Generic;
using System.Text;
using SalesTax.Products;

namespace SalesTax.Shopping
{
    public class ShoppingCart
    {
        private List<Product> productList { get; set; }

        public ShoppingCart()
        {
            productList = new List<Product>();
        }

        public void AddItemToCart(Product product)
        {
            productList.Add(product);
        }

        public List<Product> GetItemsFromCart()
        {
            return productList;
        }


    }
}
