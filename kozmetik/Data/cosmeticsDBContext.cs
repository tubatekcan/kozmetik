using kozmetik.Models;
using Microsoft.EntityFrameworkCore;


namespace kozmetik.Data
{
    public class cosmeticsDBContext : DbContext
    {
        public cosmeticsDBContext(DbContextOptions<cosmeticsDBContext> options): base(options){}

        
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories{ get; set; }
        public DbSet<Rolee> Rolees{ get; set; }
        public DbSet<Userr> Userrs{ get; set; }
        public DbSet<Cart> Carts{ get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<Product>().HasData(

                                                    new Product { ProductID = 1, ProductName = "AHA BHA SERUM",           CategoryID=2, ProductPrice = 250m, OlderPrice = 250m, Description = "buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek 1" },
                                                    new Product { ProductID = 2, ProductName = "ALOEAVERA JEL",        CategoryID=2, ProductPrice = 150m, OlderPrice = 150m, Description = "buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek 2" },
                                                    new Product { ProductID = 3, ProductName = "ANESTEZİ KREMİ",                 CategoryID=1, ProductPrice = 250m, OlderPrice = 250m, Description = "buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek 3" },
                                                    new Product { ProductID = 4, ProductName = "ANTIAGING",               CategoryID=1, ProductPrice = 150m, OlderPrice = 200m, Description = "buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek 4" },
                                                    new Product { ProductID = 5, ProductName = "ANTISPOT",            CategoryID=1, ProductPrice = 200m, OlderPrice = 400m, Description = "buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek 5" },
                                                    new Product { ProductID = 6, ProductName = "APRICOT PEELING",           CategoryID=1, ProductPrice = 100m, OlderPrice = 150m, Description = "buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek 6" },
                                                    new Product { ProductID = 7, ProductName = "BAKIM KREMİ ",            CategoryID=3, ProductPrice = 200m, OlderPrice = 250m, Description = "buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek 7" },
                                                    new Product { ProductID = 8, ProductName = "BEYAZLATICI KREM",         CategoryID=1, ProductPrice = 300m, OlderPrice = 300m, Description = "buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek 8" },
                                                    new Product { ProductID = 9, ProductName = "GEL PEELING",                 CategoryID=1, ProductPrice = 100m, OlderPrice = 150m, Description = "buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek 9" },
                                                    new Product { ProductID = 10,ProductName = "GÜNEŞ KORUYUCU",  CategoryID=2, ProductPrice = 150m, OlderPrice = 150m, Description = "buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek 10" },
                                                    new Product { ProductID = 11,ProductName = "KİL",              CategoryID=1, ProductPrice = 150m, OlderPrice = 150m, Description = "buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek 11" },
                                                    new Product { ProductID = 12,ProductName = "MOSISTURE KREM",    CategoryID=3, ProductPrice = 150m, OlderPrice = 150m, Description = "buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek 12" },
                                                    new Product { ProductID = 13,ProductName = "PİRİNÇ",    CategoryID=3, ProductPrice = 150m, OlderPrice = 150m, Description = "buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek 12" },
                                                    new Product { ProductID = 14,ProductName = "SIKILAŞTIRICI KREM",    CategoryID=3, ProductPrice = 150m, OlderPrice = 150m, Description = "buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek 12" },
                                                    new Product { ProductID = 15,ProductName = "TONIK",    CategoryID=3, ProductPrice = 150m, OlderPrice = 150m, Description = "buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek 12" },
                                                    new Product { ProductID = 16,ProductName = "TROPICAL",    CategoryID=3, ProductPrice = 150m, OlderPrice = 150m, Description = "buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek 12" },
                                                    new Product { ProductID = 17,ProductName = "VITAMIN C",    CategoryID=3, ProductPrice = 150m, OlderPrice = 150m, Description = "buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek 12" },
                                                    new Product { ProductID = 18,ProductName = "YÜZ TEMIZLEME GEL",    CategoryID=3, ProductPrice = 150m, OlderPrice = 150m, Description = "buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek 12" }
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

            modelBuilder.Entity<Rolee>().HasData(
                                                    new Rolee{RoleeID=1,RoleeName="CandidateUser"},
                                                    new Rolee{RoleeID=2,RoleeName="NormalUser"},
                                                    new Rolee{RoleeID=3,RoleeName="Admin"},
                                                    new Rolee{RoleeID=4,RoleeName="Supervisor"}
                                                    
                                                    );


            modelBuilder.Entity<Userr>().HasData(
                                                    new Userr{ UserrID=1,Emaill="candidateuser@hotmail.com",Passwordd="123456",PasswordRepeatt="123456",RoleeID=1},
                                                    new Userr{ UserrID=2,Emaill="normaluser@hotmail.com",Passwordd="123456",PasswordRepeatt="123456",RoleeID=2},
                                                    new Userr{ UserrID=3,Emaill="admin@hotmail.com",Passwordd="123456",PasswordRepeatt="123456",RoleeID=3},
                                                    new Userr{ UserrID=4,Emaill="supervisor@hotmail.com",Passwordd="123456",PasswordRepeatt="123456",RoleeID=4}


                                                    );



        }

        

    }
}
