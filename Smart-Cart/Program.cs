namespace Smart_Cart
{
    public class Program
    {
        public static void Main(string[] args)
        {

            MainMenu();

        }

        public static void MainMenu()
        {
            ShoppingCart cart = new ShoppingCart();
            GroceryStore groceryStore = new GroceryStore();
            ClothingStore clothingStore = new ClothingStore();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("\n************************* Where To Go? *************************");
                Console.WriteLine("1. Grocery Store");
                Console.WriteLine("2. Clothing Store");
                Console.WriteLine("3. View Cart");
                Console.WriteLine("4. Exit");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            groceryStore.DisplayProducts();
                            groceryStore.addToCart(cart);
                            break;
                        case 2:
                            clothingStore.DisplayProducts();
                            clothingStore.addToCart(cart);
                            break;
                        case 3:
                            cart.ViewItems();
                            break;
                        case 4:
                            Console.WriteLine("Thank you for shopping with us!");
                            return;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
                Console.ReadKey();
            }
        }
    }
}