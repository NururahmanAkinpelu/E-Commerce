using Domain.Entitties;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class ECommerceDbContext : DbContext
    {
        public ECommerceDbContext(DbContextOptions<ECommerceDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartProduct> CartProducts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Apply default precision to all decimal properties
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                var decimalProps = entityType.GetProperties()
                    .Where(p => p.ClrType == typeof(decimal) || p.ClrType == typeof(decimal?));

                foreach (var property in decimalProps)
                {
                    property.SetPrecision(18);
                    property.SetScale(2);
                }
            }

            // Seed data
            SeedData(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }

        private void SeedData(ModelBuilder modelBuilder)
        {
            // Seed Users
            var users = new List<User>
            {
                new User
                {
                    Id = Guid.Parse("11111111-1111-1111-1111-111111111111"),
                    FirstName = "John",
                    LastName = "Doe",
                    Email = "john.doe@example.com",
                    PasswordHash = "hashedpassword123", // In real app, this should be properly hashed
                    PhoneNumber = "+1234567890",
                    Address = "123 Main St, New York, NY 10001",
                    IsEmailVerified = true,
                    IsPhoneNumberVerified = false,
                    ProfilePictureUrl = "https://example.com/profiles/john.jpg",
                    Role = "User",
                    CreatedOn = DateTime.UtcNow,
                    IsDeleted = false
                },
                new User
                {
                    Id = Guid.Parse("22222222-2222-2222-2222-222222222222"),
                    FirstName = "Jane",
                    LastName = "Smith",
                    Email = "jane.smith@example.com",
                    PasswordHash = "hashedpassword456",
                    PhoneNumber = "+1987654321",
                    Address = "456 Oak Ave, Los Angeles, CA 90210",
                    IsEmailVerified = true,
                    IsPhoneNumberVerified = true,
                    ProfilePictureUrl = "https://example.com/profiles/jane.jpg",
                    Role = "User",
                    CreatedOn = DateTime.UtcNow,
                    IsDeleted = false
                },
                new User
                {
                    Id = Guid.Parse("33333333-3333-3333-3333-333333333333"),
                    FirstName = "Admin",
                    LastName = "User",
                    Email = "admin@example.com",
                    PasswordHash = "hashedpasswordadmin",
                    PhoneNumber = "+1555666777",
                    Address = "789 Admin Blvd, Chicago, IL 60601",
                    IsEmailVerified = true,
                    IsPhoneNumberVerified = true,
                    ProfilePictureUrl = "https://example.com/profiles/admin.jpg",
                    Role = "Admin",
                    CreatedOn = DateTime.UtcNow,
                    IsDeleted = false
                }
            };

            // Seed Products
            var products = new List<Product>
            {
                new Product
                {
                    Id = Guid.Parse("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                    Name = "Wireless Bluetooth Headphones",
                    Description = "High-quality wireless headphones with noise cancellation and 30-hour battery life",
                    Price = 99.99m,
                    StockQuantity = 50,
                    Category = "Electronics",
                    ImageUrl = "https://example.com/products/headphones.jpg",
                    CreatedOn = DateTime.UtcNow,
                    IsDeleted = false
                },
                new Product
                {
                    Id = Guid.Parse("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                    Name = "Smartphone Case",
                    Description = "Durable protective case for smartphones with shock absorption",
                    Price = 24.99m,
                    StockQuantity = 100,
                    Category = "Accessories",
                    ImageUrl = "https://example.com/products/phone-case.jpg",
                    CreatedOn = DateTime.UtcNow,
                    IsDeleted = false
                },
                new Product
                {
                    Id = Guid.Parse("cccccccc-cccc-cccc-cccc-cccccccccccc"),
                    Name = "Coffee Maker",
                    Description = "Programmable coffee maker with 12-cup capacity and auto-shutoff feature",
                    Price = 79.99m,
                    StockQuantity = 25,
                    Category = "Home & Kitchen",
                    ImageUrl = "https://example.com/products/coffee-maker.jpg",
                    CreatedOn = DateTime.UtcNow,
                    IsDeleted = false
                },
                new Product
                {
                    Id = Guid.Parse("dddddddd-dddd-dddd-dddd-dddddddddddd"),
                    Name = "Gaming Mouse",
                    Description = "High-precision gaming mouse with RGB lighting and programmable buttons",
                    Price = 59.99m,
                    StockQuantity = 75,
                    Category = "Electronics",
                    ImageUrl = "https://example.com/products/gaming-mouse.jpg",
                    CreatedOn = DateTime.UtcNow,
                    IsDeleted = false
                },
                new Product
                {
                    Id = Guid.Parse("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                    Name = "Yoga Mat",
                    Description = "Non-slip yoga mat with extra cushioning for comfortable practice",
                    Price = 29.99m,
                    StockQuantity = 40,
                    Category = "Sports & Fitness",
                    ImageUrl = "https://example.com/products/yoga-mat.jpg",
                    CreatedOn = DateTime.UtcNow,
                    IsDeleted = false
                },
                new Product
                {
                    Id = Guid.Parse("11111111-1111-1111-1111-111111111111"),
                    Name = "Wireless Charging Pad",
                    Description = "Fast wireless charging pad compatible with all Qi-enabled devices",
                    Price = 39.99m,
                    StockQuantity = 60,
                    Category = "Electronics",
                    ImageUrl = "https://example.com/products/wireless-charger.jpg",
                    CreatedOn = DateTime.UtcNow,
                    IsDeleted = false
                },
                new Product
                {
                    Id = Guid.Parse("22222222-2222-2222-2222-222222222222"),
                    Name = "Bluetooth Speaker",
                    Description = "Portable waterproof Bluetooth speaker with 360-degree sound",
                    Price = 89.99m,
                    StockQuantity = 35,
                    Category = "Electronics",
                    ImageUrl = "https://example.com/products/bluetooth-speaker.jpg",
                    CreatedOn = DateTime.UtcNow,
                    IsDeleted = false
                },
                new Product
                {
                    Id = Guid.Parse("33333333-3333-3333-3333-333333333333"),
                    Name = "Laptop Stand",
                    Description = "Adjustable aluminum laptop stand for better ergonomics",
                    Price = 49.99m,
                    StockQuantity = 45,
                    Category = "Accessories",
                    ImageUrl = "https://example.com/products/laptop-stand.jpg",
                    CreatedOn = DateTime.UtcNow,
                    IsDeleted = false
                },
                new Product
                {
                    Id = Guid.Parse("44444444-4444-4444-4444-444444444444"),
                    Name = "Water Bottle",
                    Description = "Insulated stainless steel water bottle that keeps drinks cold for 24 hours",
                    Price = 19.99m,
                    StockQuantity = 80,
                    Category = "Sports & Fitness",
                    ImageUrl = "https://example.com/products/water-bottle.jpg",
                    CreatedOn = DateTime.UtcNow,
                    IsDeleted = false
                },
                new Product
                {
                    Id = Guid.Parse("55555555-5555-5555-5555-555555555555"),
                    Name = "LED Desk Lamp",
                    Description = "Adjustable LED desk lamp with USB charging port and touch controls",
                    Price = 34.99m,
                    StockQuantity = 30,
                    Category = "Home & Office",
                    ImageUrl = "https://example.com/products/desk-lamp.jpg",
                    CreatedOn = DateTime.UtcNow,
                    IsDeleted = false
                },
                new Product
                {
                    Id = Guid.Parse("66666666-6666-6666-6666-666666666666"),
                    Name = "Wireless Earbuds",
                    Description = "True wireless earbuds with active noise cancellation and 8-hour battery",
                    Price = 129.99m,
                    StockQuantity = 40,
                    Category = "Electronics",
                    ImageUrl = "https://example.com/products/wireless-earbuds.jpg",
                    CreatedOn = DateTime.UtcNow,
                    IsDeleted = false
                },
                new Product
                {
                    Id = Guid.Parse("77777777-7777-7777-7777-777777777777"),
                    Name = "Fitness Tracker",
                    Description = "Smart fitness tracker with heart rate monitor and sleep tracking",
                    Price = 79.99m,
                    StockQuantity = 55,
                    Category = "Sports & Fitness",
                    ImageUrl = "https://example.com/products/fitness-tracker.jpg",
                    CreatedOn = DateTime.UtcNow,
                    IsDeleted = false
                },
                new Product
                {
                    Id = Guid.Parse("88888888-8888-8888-8888-888888888888"),
                    Name = "Kitchen Scale",
                    Description = "Digital kitchen scale with precision weighing up to 11 lbs",
                    Price = 24.99m,
                    StockQuantity = 25,
                    Category = "Home & Kitchen",
                    ImageUrl = "https://example.com/products/kitchen-scale.jpg",
                    CreatedOn = DateTime.UtcNow,
                    IsDeleted = false
                }
            };

            modelBuilder.Entity<User>().HasData(users);
            modelBuilder.Entity<Product>().HasData(products);
        }
    }
}