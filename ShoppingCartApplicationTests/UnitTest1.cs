using Smart_Cart;

namespace ShoppingCartApplicationTests
{
    public class UnitTest1
    {
        [Fact]
        public void AddItem()
        {
            //Arrange
            ShoppingCart cart = new ShoppingCart();
            Product product = new Product { Name = "Apple", Price = 10 };

            // Act
            cart.AddItem(product);

            // Assert
            Assert.True(cart.AddItem(product));
        }

        [Fact]
        public void RemoveItem()
        {
            //Arrange
            ShoppingCart cart = new ShoppingCart();
            Product product = new Product { Name = "Test Item", Price = 10 };

            // Act
            cart.AddItem(product);

            // Assert
            Assert.True(cart.RemoveItem(product));
        }

        [Fact]
        public void CheckTotalCost()
        {
            //Arrange
            ShoppingCart cart = new ShoppingCart();
            Product product1 = new Product { Name = "Test 1", Price = 10 };
            Product product2 = new Product { Name = "Test 2", Price = 20 };

            // Act
            cart.AddItem(product1);
            cart.AddItem(product2);
            int total = cart.CalculateTotalCost();

            // Assert
            Assert.Equal(total , 30);
        }
    }
}