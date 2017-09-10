using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EfCoreSqlite
{
    public interface IProductsRepository
    {
        Task<IEnumerable<Product>> GetProductsAsync();

        Task<Product> GetProductByIdAsync(int id);

        Task<bool> AddProductAsync(Product product);

        Task<bool> UpdateProductAsync(Product product);

        Task<bool> RemoveProductAsync(int id);

        Task<IEnumerable<Product>> QueryProductsAsync(Func<Product, bool> predicate);
    }
}
