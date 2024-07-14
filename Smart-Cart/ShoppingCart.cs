using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Cart
{
    public class ShoppingCart
    {
        private List<Product> items = new List<Product>();

        public void AddItem(Product product)
        {
            items.Add(product);
            Console.WriteLine($"{product.Name} added to the cart.");
        }

        public void RemoveItem(Product product)
        {
            if (items.Remove(product))
            {
                Console.WriteLine($"{product.Name} removed from the cart.");
            }
            else
            {
                Console.WriteLine($"{product.Name} not found in the cart.");
            }
        }

        public void ViewItems()
        {
            Console.Clear();
            Console.WriteLine("************************* Your Cart *************************");
            Console.WriteLine("Items in your cart:");
            if (items.Count == 0)
            {
                Console.WriteLine("Your cart is empty.");
                return;
            }

            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {items[i]}");
            }
            Action();
            Console.ReadKey();
        }

        public int CalculateTotalCost()
        {
            int total = Convert.ToInt16(items.Sum(item => item.Price));
            return total;
        }

        public void Action()
        {
            Console.WriteLine("\nPlease Select: \n1. Remove Item \n2. Calculate The Total Cost \n3. Checkout \n4. Back To Main Menu");
            int choice = Convert.ToInt16(Console.ReadLine());
            int totalCost = CalculateTotalCost();

            switch (choice)
            {
                case 1:
                    Console.WriteLine("\nEnter the item number to remove:");
                    if (int.TryParse(Console.ReadLine(), out int num) && num > 0 && num <= items.Count)
                    {
                        RemoveItem(items[num - 1]);
                    }
                    break;
                case 2:
                    Console.WriteLine($"Total Cost: {totalCost} $");
                    break;
                case 3:
                    Console.WriteLine("************************* Checkout *************************");
                    Console.WriteLine($"Your Total Cost: {totalCost} $");
                    Console.WriteLine("The Captin will contact with you within 1 hour");
                    Console.WriteLine("Thank you for shopping with us!");
                    break;
                case 4:
                    break;
                default:
                    break;
            }
        }
    }
}