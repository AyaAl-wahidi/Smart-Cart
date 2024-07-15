using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Cart
{
    public class ShoppingCart
    {
        public List<Product> items = new List<Product>();

        public bool AddItem(Product product)
        {
            int count = items.Count;
            
            items.Add(product);
            Console.WriteLine($"{product.Name} Added To Your Cart.");
            if (items.Count == count + 1)
            {
                return true;
            }
            return false;
        }

        public bool RemoveItem(Product product)
        {
            if (items.Remove(product) == true)
            {
                Console.WriteLine($"{product.Name} Removed From The Cart.");
                return true;
            }
            else
            {
                Console.WriteLine($"{product.Name} Not Found In The Cart.");
                return false;
            }
        }

        public void ViewItems()
        {
            Console.WriteLine("************************* Your Cart *************************");
            Console.WriteLine("Items In Your Cart:");
            if (items.Count == 0)
            {
                Console.WriteLine("Your Cart Is Empty!");
                return;
            }

            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {items[i]}");
            }
            Action();
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
                    Console.WriteLine("\nEnter The Item Number To Remove It From Your Card:");
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