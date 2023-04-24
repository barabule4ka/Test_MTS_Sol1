using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_8
{
    /// <summary>
    /// Было сложно придумать кучу продуктов, потому используется нумерация))
    /// </summary>
    public class Shop
    {
        public List<Product> Products { get; } = new List<Product>();
        public Shop()
        {
            Products = new List<Product>() { 
                new Product("Product1", 78),
                new Product("Product2", 226),
                new Product("Product3", 100),
                new Product("Product4", 252),
                new Product("Product5", 150),
                new Product("Product6", 400),
                new Product("Product7", 320),
                new Product("Product8", 158),
                new Product("Product9", 500),
                new Product("Product10", 50),
            };
        }

        public Product GetProduct()
        {
            Random rand = new Random();
            return Products[(int)rand.NextInt64(0, Products.Count - 1)];
        }
    }
}
