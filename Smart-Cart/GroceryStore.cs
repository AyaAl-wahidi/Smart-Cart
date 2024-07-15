using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Smart_Cart.Product;

namespace Smart_Cart
{
    public class GroceryStore
    {
        private List<Product> products = new List<Product>();

        public GroceryStore()
        {
            products.Add(new Product { Name = "Food1", Price = 10, Category = ProductCategory.Food });
            products.Add(new Product { Name = "Food2", Price = 20, Category = ProductCategory.Food });
            products.Add(new Product { Name = "Food3", Price = 30, Category = ProductCategory.Food });
            products.Add(new Product { Name = "Food4", Price = 40, Category = ProductCategory.Food });
            products.Add(new Product { Name = "Food5", Price = 50, Category = ProductCategory.Food });
        }

        public void DisplayProducts()
        {
            Console.WriteLine("Products Available In The Grocery Store:");
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {products[i]}");
            }
        }

        public void addToCart(ShoppingCart cart)
        {
            Console.WriteLine("Enter The Product Number To Add To The Cart:");
            if (int.TryParse(Console.ReadLine(), out int num) && num > 0 && num <= products.Count)
            {
                cart.AddItem(products[num - 1]);
            }
            else
            {
                Console.WriteLine("Invalid Input!");
            }
        }
    }
}