using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GardenApp.Data
{
    public class ProductService
    {
        private readonly List<Product> _products;

        public ProductService()
        {
            _products = new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Name = "Green Bonsai",
                    Category = "Bonsai",
                    Price = 39.99m,
                    Rating = 4.7,
                    Description = "A beautifully shaped bonsai tree, perfect for indoor decoration. Requires minimal maintenance and adds tranquility to your home.",
                    Image = "assets/bonsai_small.png"
                },
                new Product
                {
                    Id = 2,
                    Name = "Happy Succulent",
                    Category = "Succulent",
                    Price = 18.00m,
                    Rating = 4.8,
                    Description = "An adorable succulent planted in a pot with a smiley face. Easy to care for and brings joy to any space.",
                    Image = "assets/happy_succulent.png"
                },
                new Product
                {
                    Id = 3,
                    Name = "Haworthia Succulent",
                    Category = "Succulent",
                    Price = 22.50m,
                    Rating = 4.6,
                    Description = "A hardy haworthia plant with striking patterns on its leaves. Ideal for beginners.",
                    Image = "assets/haworthia_succulent.png"
                },
                new Product
                {
                    Id = 4,
                    Name = "Yellow Grass",
                    Category = "Grass",
                    Price = 12.00m,
                    Rating = 4.2,
                    Description = "A fresh pot of yellow‑tipped grass that brightens up any corner. Perfect for desktops and small spaces.",
                    Image = "assets/yellow_grass.png"
                },
                new Product
                {
                    Id = 5,
                    Name = "Japanese Bonsai",
                    Category = "Bonsai",
                    Price = 55.00m,
                    Rating = 4.9,
                    Description = "A majestic Japanese bonsai tree cultivated for years. A premium addition for enthusiasts.",
                    Image = "assets/bonsai_large.png"
                },
                new Product
                {
                    Id = 6,
                    Name = "Blue Cactus",
                    Category = "Cactus",
                    Price = 16.50m,
                    Rating = 4.5,
                    Description = "A rare blue cactus with striking colors. Low maintenance and drought tolerant.",
                    Image = "assets/blue_cactus.png"
                }
            };
        }

        /// <summary>
        /// Asynchronously returns all products.  We wrap the list in a
        /// Task to simulate an asynchronous API call.
        /// </summary>
        public Task<List<Product>> GetProductsAsync() => Task.FromResult(_products);

        /// <summary>
        /// Returns the product with the specified identifier or null if
        /// it doesn’t exist.
        /// </summary>
        public Task<Product?> GetProductByIdAsync(int id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);
            return Task.FromResult(product);
        }

        /// <summary>
        /// Returns the top N trending products sorted by rating in
        /// descending order.  If count is larger than the number of
        /// available products the entire list is returned.
        /// </summary>
        public Task<List<Product>> GetTrendingAsync(int count = 3)
        {
            var trending = _products
                .OrderByDescending(p => p.Rating)
                .Take(count)
                .ToList();
            return Task.FromResult(trending);
        }

        /// <summary>
        /// Returns products filtered by the supplied category name.
        /// Category filtering is case‑insensitive.  If the category
        /// parameter is null or empty the complete list is returned.
        /// </summary>
        public Task<List<Product>> GetByCategoryAsync(string? category)
        {
            if (string.IsNullOrWhiteSpace(category))
            {
                return Task.FromResult(_products);
            }
            var filtered = _products.Where(p => string.Equals(p.Category, category, System.StringComparison.OrdinalIgnoreCase)).ToList();
            return Task.FromResult(filtered);
        }

        /// <summary>
        /// Returns products whose names contain the provided search term
        /// (case‑insensitive).  If the search term is null or empty the
        /// complete list is returned.
        /// </summary>
        public Task<List<Product>> SearchAsync(string? term)
        {
            if (string.IsNullOrWhiteSpace(term))
            {
                return Task.FromResult(_products);
            }
            var filtered = _products.Where(p => p.Name.Contains(term, System.StringComparison.OrdinalIgnoreCase)).ToList();
            return Task.FromResult(filtered);
        }
    }
}