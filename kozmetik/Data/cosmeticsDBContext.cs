using kozmetik.Models;
using Microsoft.EntityFrameworkCore;

namespace kozmetik.Data
{
    public class cosmeticsDBContext : DbContext
    {
        public cosmeticsDBContext(DbContextOptions<cosmeticsDBContext> options): base(options){}

        
        public DbSet<kozmetik.Models.Product> Product { get; set; }
        public DbSet<kozmetik.Models.Category> Category{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<Product>().HasData(

                                                    new Product { ProductID = 1, ProductName = "Yüz Yıkama Jeli",     CategoryID=2, ProductPrice = 250m, OlderPrice = 250m, Description = "buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek 1" },
                                                    new Product { ProductID = 2, ProductName = "Cilt Maskesi",        CategoryID=2, ProductPrice = 150m, OlderPrice = 150m, Description = "buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek 2" },
                                                    new Product { ProductID = 3, ProductName = "Ruj",                 CategoryID=1, ProductPrice = 250m, OlderPrice = 250m, Description = "buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek 3" },
                                                    new Product { ProductID = 4, ProductName = "Rimel",               CategoryID=1, ProductPrice = 150m, OlderPrice = 200m, Description = "buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek 4" },
                                                    new Product { ProductID = 5, ProductName = "Fondöten",            CategoryID=1, ProductPrice = 200m, OlderPrice = 400m, Description = "buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek 5" },
                                                    new Product { ProductID = 6, ProductName = "EyeShadow",           CategoryID=1, ProductPrice = 100m, OlderPrice = 150m, Description = "buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek 6" },
                                                    new Product { ProductID = 7, ProductName = "Peeling ",            CategoryID=3, ProductPrice = 200m, OlderPrice = 250m, Description = "buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek 7" },
                                                    new Product { ProductID = 8, ProductName = "Highlighter",         CategoryID=1, ProductPrice = 300m, OlderPrice = 300m, Description = "buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek 8" },
                                                    new Product { ProductID = 9, ProductName = "Oje",                 CategoryID=1, ProductPrice = 100m, OlderPrice = 150m, Description = "buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek 9" },
                                                    new Product { ProductID = 10,ProductName = "Makyaj Sabitleyici",  CategoryID=2, ProductPrice = 150m, OlderPrice = 150m, Description = "buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek 10" },
                                                    new Product { ProductID = 11,ProductName = "Sünger",              CategoryID=1, ProductPrice = 150m, OlderPrice = 150m, Description = "buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek 11" },
                                                    new Product { ProductID = 12,ProductName = "Makyaj Temizleme",    CategoryID=3, ProductPrice = 150m, OlderPrice = 150m, Description = "buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek 12" }
                                                    );
            modelBuilder.Entity<Category>().HasData(
                                                    new Category { CategoryID=1, CategoryName="Makyaj"},
                                                    new Category { CategoryID=2, CategoryName="Cilt Bakımı"},
                                                    new Category { CategoryID=3, CategoryName="Sağlık-Hijyen"},
                                                    new Category { CategoryID=4, CategoryName="Anne-Bebek"},
                                                    new Category { CategoryID=5, CategoryName="Ev-Yaşam"},
                                                    new Category { CategoryID=6, CategoryName="Saç Bakım"},
                                                    new Category { CategoryID=7, CategoryName="Parfüm-Deodorant"},
                                                    new Category { CategoryID=8, CategoryName="Erkek Bakım"}
                                                    );

        
        }

        

    }
}
