using Microsoft.EntityFrameworkCore;
using ShopOnline.Api.Entities;

namespace ShopOnline.Api.Data
{
    public class ShopOnlineDbContext : DbContext
    {
        public ShopOnlineDbContext(DbContextOptions<ShopOnlineDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Products
            //Sábanas para cama sencilla 1
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 1,
                Name = "Sábanas para cama sencilla 1",
                Description = "Sábanas género unisex colchon con dimensiones largo xx, ancho xx, alto xx",
                ImageURL = "/Images/SabanasCamaSencilla/sencilla1.jpg",
                Price = 100,
                Qty = 100,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Name = "Sábanas para cama sencilla 2",
                Description = "Sábanas género unisex colchon con dimensiones largo xx, ancho xx, alto xx",
                ImageURL = "/Images/SabanasCamaSencilla/sencilla2.jpg",
                Price = 50,
                Qty = 45,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "Sábanas para cama sencilla 3",
                Description = "Sábanas género unisex colchon con dimensiones largo xx, ancho xx, alto xx",
                ImageURL = "/Images/SabanasCamaSencilla/sencilla3.jpg",
                Price = 20,
                Qty = 30,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                Name = "Sábanas para cama sencilla 4",
                Description = "Sábanas género unisex colchon con dimensiones largo xx, ancho xx, alto xx",
                ImageURL = "/Images/SabanasCamaSencilla/sencilla4.jpg",
                Price = 50,
                Qty = 60,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 5,
                Name = "Sábanas para cama sencilla 5",
                Description = "Sábanas género unisex colchon con dimensiones largo xx, ancho xx, alto xx",
                ImageURL = "/Images/SabanasCamaSencilla/sencilla5.jpg",
                Price = 30,
                Qty = 85,
                CategoryId = 1

            });
            //Sábanas para cama doble
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 6,
                Name = "Sábanas para cama doble 1",
                Description = "Sábanas género unisex colchon con dimensiones largo xx, ancho xx, alto xx",
                ImageURL = "/Images/SabanasCamaDoble/doble1.jpg",
                Price = 100,
                Qty = 120,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 7,
                Name = "Sábanas para cama doble 2",
                Description = "Sábanas género unisex colchon con dimensiones largo xx, ancho xx, alto xx",
                ImageURL = "/Images/SabanasCamaDoble/doble2.jpg",
                Price = 40,
                Qty = 200,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 8,
                Name = "Sábanas para cama doble 3",
                Description = "Sábanas género unisex colchon con dimensiones largo xx, ancho xx, alto xx",
                ImageURL = "/Images/SabanasCamaDoble/doble3.jpg",
                Price = 40,
                Qty = 300,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 9,
                Name = "Sábanas para cama doble 4",
                Description = "Sábanas género unisex colchon con dimensiones largo xx, ancho xx, alto xx",
                ImageURL = "/Images/SabanasCamaDoble/doble4.jpg",
                Price = 600,
                Qty = 20,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 10,
                Name = "Sábanas para cama doble 5",
                Description = "Sábanas género unisex colchon con dimensiones largo xx, ancho xx, alto xx",
                ImageURL = "/Images/SabanasCamaDoble/doble5.jpg",
                Price = 500,
                Qty = 15,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 11,
                Name = "Sábanas para cama doble 6",
                Description = "Sábanas género unisex colchon con dimensiones largo xx, ancho xx, alto xx",
                ImageURL = "/Images/SabanasCamaDoble/doble6.jpg",
                Price = 100,
                Qty = 60,
                CategoryId = 3
            });
            //Sábanas para cama semi doble 
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 12,
                Name = "Sábanas para cama semi doble 1",
                Description = "Sábanas género unisex colchon con dimensiones largo xx, ancho xx, alto xx",
                ImageURL = "/Images/SabanasCamaSemiDoble/semidoble1.jpg",
                Price = 50,
                Qty = 212,
                CategoryId = 2
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 13,
                Name = "Sábanas para cama semi doble 2",
                Description = "Sábanas género unisex colchon con dimensiones largo xx, ancho xx, alto xx",
                ImageURL = "/Images/SabanasCamaSemiDoble/semidoble2.jpg",
                Price = 50,
                Qty = 112,
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 14,
                Name = "Sábanas para cama semi doble 3",
                Description = "Sábanas género unisex colchon con dimensiones largo xx, ancho xx, alto xx",
                ImageURL = "/Images/SabanasCamaSemiDoble/semidoble3.jpg",
                Price = 70,
                Qty = 90,
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 15,
                Name = "Sábanas para cama semi doble 4",
                Description = "Sábanas género unisex colchon con dimensiones largo xx, ancho xx, alto xx",
                ImageURL = "/Images/SabanasCamaSemiDoble/semidoble4.jpg",
                Price = 120,
                Qty = 95,
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 16,
                Name = "Sábanas para cama semi doble 5",
                Description = "Sábanas género unisex colchon con dimensiones largo xx, ancho xx, alto xx",
                ImageURL = "/Images/SabanasCamaSemiDoble/semidoble5.jpg",
                Price = 15,
                Qty = 100,
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 17,
                Name = "Sábanas para cama semi doble 6",
                Description = "Sábanas género unisex colchon con dimensiones largo xx, ancho xx, alto xx",
                ImageURL = "/Images/SabanasCamaSemiDoble/semidoble6.jpg",
                Price = 20,
                Qty = 73,
                CategoryId = 2
            });
            //Protector colchón cama sencilla
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 18,
                Name = "Protector colchón cama sencilla 1",
                Description = "Protector anti fluidos colchon con dimensiones largo xx, ancho xx, alto xx",
                ImageURL = "/Images/ProtectorColchonCamaSencilla/protectorsencillo1.jpg",
                Price = 100,
                Qty = 50,
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 19,
                Name = "Protector colchón cama sencilla 2",
                Description = "Protector anti fluidos colchon con dimensiones largo xx, ancho xx, alto xx",
                ImageURL = "/Images/ProtectorColchonCamaSencilla/protectorsencillo2.jpg",
                Price = 150,
                Qty = 60,
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 20,
                Name = "Protector colchón cama sencilla 3",
                Description = "Protector anti fluidos colchon con dimensiones largo xx, ancho xx, alto xx",
                ImageURL = "/Images/ProtectorColchonCamaSencilla/protectorsencillo3.jpg",
                Price = 200,
                Qty = 70,
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 21,
                Name = "Protector colchón cama sencilla 4",
                Description = "Protector anti fluidos colchon con dimensiones largo xx, ancho xx, alto xx",
                ImageURL = "/Images/ProtectorColchonCamaSencilla/protectorsencillo4.jpg",
                Price = 120,
                Qty = 120,
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 22,
                Name = "Protector colchón cama sencilla 5",
                Description = "Protector anti fluidos colchon con dimensiones largo xx, ancho xx, alto xx",
                ImageURL = "/Images/ProtectorColchonCamaSencilla/protectorsencillo5.jpg",
                Price = 200,
                Qty = 100,
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 23,
                Name = "Protector colchón cama sencilla 6",
                Description = "Protector anti fluidos colchon con dimensiones largo xx, ancho xx, alto xx",
                ImageURL = "/Images/ProtectorColchonCamaSencilla/protectorsencillo6.jpg",
                Price = 50,
                Qty = 150,
                CategoryId = 4
            });

            //Add users
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 1,
                UserName = "Miguel"

            });
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 2,
                UserName = "Lucía"

            });

            //Create Shopping Cart for Users
            modelBuilder.Entity<Cart>().HasData(new Cart
            {
                Id = 1,
                UserId = 1

            });
            modelBuilder.Entity<Cart>().HasData(new Cart
            {
                Id = 2,
                UserId = 2

            });
            //Add Product Categories
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 1,
                Name = "Sábanas colchón cama sencilla"
            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 2,
                Name = "Sábanas colchón cama semi doble"
            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 3,
                Name = "Sábanas colchón cama doble"
            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 4,
                Name = "Protectores colchón cama sencilla"
            });

        }

        public DbSet<Cart> Carts { get; set; }

        public DbSet<CartItem> CartItems { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<ProductCategory> ProductCategories { get; set; }

        public DbSet<User> Users { get; set; }
    }
			
}
