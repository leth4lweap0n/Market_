
using Microsoft.EntityFrameworkCore;

namespace Market.Entity
{
    public class ExampleDBContext : DbContext
    {
        public DbSet<Users>? Users { get; set; }
        public DbSet<Products>? Products { get; set; }
        public DbSet<ConfirmedSalesInfo>? ConfirmedSalesInfo { get; set; }
        public DbSet<CancelledSalesInfo>? CancelledSalesInfo { get; set; }
        public DbSet<QuickSaleCommonProducts>? QuickSaleCommonProducts { get; set; }
        public DbSet<Sale>? Sale { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=ATES-DESKTOP\\MSSQLSERVERDEV19;" +
                                        "Database=ExampleDB;" +
                                        "TrustServerCertificate = True;" +
                                        "uid =sa;" +
                                        "pwd=a24t87e33S75;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>()
                .Property(b => b.Permission)
                .HasDefaultValue(true);
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Products>().HasData(
                new Products { Barkod = 1, Name = "Apple", Price = 2, Stock = 10 },
                new Products { Barkod = 2, Name = "Orange", Price = 3, Stock = 10 },
                new Products { Barkod = 3, Name = "Banana", Price = 4, Stock = 10 },
                new Products { Barkod = 4, Name = "Pineapple", Price = 5, Stock = 10 },
                new Products { Barkod = 5, Name = "Watermelon", Price = 6, Stock = 10 },
                new Products { Barkod = 6, Name = "Strawberry", Price = 7, Stock = 10 },
                new Products { Barkod = 7, Name = "Peach", Price = 8, Stock = 10 },
                new Products { Barkod = 8, Name = "Pear", Price = 9, Stock = 10 },
                new Products { Barkod = 9, Name = "Grape", Price = 10, Stock = 10 },
                new Products { Barkod = 10, Name = "Cherry", Price = 1, Stock = 10 },
                new Products { Barkod = 11, Name = "Mango", Price = 2, Stock = 10 },
                new Products { Barkod = 12, Name = "Pomegranate", Price = 13, Stock = 10 },
                new Products { Barkod = 13, Name = "Kiwi", Price = 14, Stock = 10 },
                new Products { Barkod = 14, Name = "Lemon", Price = 15, Stock = 10 },
                new Products { Barkod = 15, Name = "Lime", Price = 16, Stock = 10 },
                new Products { Barkod = 16, Name = "Raspberry", Price = 17, Stock = 10 },
                new Products { Barkod = 17, Name = "Blueberry", Price = 18, Stock = 10 }
            );
            modelBuilder.Entity<QuickSaleCommonProducts>().HasData(
                new QuickSaleCommonProducts { Id = 1, ProductBarkod = 1 },
                new QuickSaleCommonProducts { Id = 2, ProductBarkod = 2 },
                new QuickSaleCommonProducts { Id = 3, ProductBarkod = 3 },
                new QuickSaleCommonProducts { Id = 4, ProductBarkod = 4 },
                new QuickSaleCommonProducts { Id = 5, ProductBarkod = 5 },
                new QuickSaleCommonProducts { Id = 6, ProductBarkod = 6 },
                new QuickSaleCommonProducts { Id = 7, ProductBarkod = 7 },
                new QuickSaleCommonProducts { Id = 8, ProductBarkod = 8 },
                new QuickSaleCommonProducts { Id = 9, ProductBarkod = 9 },
                new QuickSaleCommonProducts { Id = 10, ProductBarkod = 10 },
                new QuickSaleCommonProducts { Id = 11, ProductBarkod = 11 },
                new QuickSaleCommonProducts { Id = 12, ProductBarkod = 12 },
                new QuickSaleCommonProducts { Id = 13, ProductBarkod = 13 },
                new QuickSaleCommonProducts { Id = 14, ProductBarkod = 14 },
                new QuickSaleCommonProducts { Id = 15, ProductBarkod = 15 }
            );
        }
    }
}
