using Microsoft.EntityFrameworkCore;

namespace CRUD.Api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
