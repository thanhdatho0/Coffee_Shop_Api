using Coffee_Shop_Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Coffee_Shop_Api.Data
{
    public class ApplicationDBContext(DbContextOptions dbContextOptions) : DbContext(dbContextOptions)
    {

        #region DbSet Region
        public DbSet<Category> Categories { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Ingredient> Incredients { get; set; }
        public DbSet<IngredientDetail> IncredientDetails { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Product_Incredient> Product_Incredients { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<Zone> Zones { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<OrderDetail>().HasKey(od => new { od.OrderId, od.ProductId });
            modelBuilder.Entity<Product_Incredient>().HasKey(pi => new { pi.ProductId, pi.IncredientId });
            modelBuilder.Entity<IngredientDetail>().HasKey(id => new { id.IncredientId });

            modelBuilder.Entity<Product>()
                .HasMany(p => p.OrderDetails)
                .WithOne(p => p.Product);

            modelBuilder.Entity<Order>()
                .HasMany(o => o.OrderDetails)
                .WithOne(o => o.Order);
            
            modelBuilder.Entity<Ingredient>()
                .HasMany(i => i.IncredientDetails)
                .WithOne(i => i.Incredient);
        }
    }
}
