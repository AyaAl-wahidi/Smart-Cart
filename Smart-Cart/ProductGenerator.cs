using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Cart
{
    public class ProductGenerator
    {
        private static Random random = new Random();

        public static Product GenerateProduct()
        {
            int type = random.Next(0, 2); // 0 for food, 1 for clothing

            if (type == 0)
            {
                return new Product
                {
                    Name = $"Food {random.Next(1, 100)}",
                    Price = random.Next(5, 100),
                    Category = Product.ProductCategory.Food
                };
            }
            else
            {
                return new Product
                {
                    Name = $"Clothing {random.Next(1, 100)}",
                    Price = random.Next(10, 200),
                    Category = Product.ProductCategory.Clothing
                };
            }
        }
    }
}