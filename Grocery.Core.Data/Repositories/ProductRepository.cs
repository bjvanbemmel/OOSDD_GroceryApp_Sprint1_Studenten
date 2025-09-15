using Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Models;

namespace Grocery.Core.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> Products { get; set; }
        public ProductRepository()
        {
            Products = new List<Product>()
            {
                new Product(0, "Melk", 300),
                new Product(1, "Kaas", 100),
                new Product(2, "Brood", 400),
                new Product(3, "Cornflakes", 0)
            };
        }

        public List<Product> GetAll()
        {
            return Products;
        }

        public Product? Get(int id)
        {
            return Products.FirstOrDefault(p => p.Id == id);
        }

        public Product Add(Product item)
        {
            throw new NotImplementedException();
        }

        public Product? Delete(Product item)
        {
            throw new NotImplementedException();
        }

        public Product? Update(Product item)
        {
            throw new NotImplementedException();
        }
    }
}
