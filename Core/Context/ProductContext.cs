using Core.Domain;
using System.Data.Entity;

namespace Core.Context
{
    /// <summary>
    /// Контекст данных товаров.
    /// </summary>
    public class ProductContext : DbContext
    {
        public ProductContext() : base("DirectoryProducts")
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
