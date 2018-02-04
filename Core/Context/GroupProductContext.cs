using Core.Domain;
using System.Data.Entity;

namespace Core.Context
{
    /// <summary>
    /// Контекст данных групп товаров.
    /// </summary>
    public class GroupProductContext : DbContext
    {
        public GroupProductContext() : base("DirectoryProducts")
        { }

        public DbSet<GroupProduct> GroupProducts { get; set; }
    }
}
