using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIAuthenticate.Model.Authentication;
using WebAPIAuthenticate.Model.Product;

namespace WebAPIAuthenticate.DataAccessLayer
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Seed Data for Category
            builder.Entity<Category>().HasData(
                   new Category() { Id = 1, Name = "Essential" },
                   new Category() { Id = 2, Name = "Apparel" },
                   new Category() { Id = 3, Name = "Gadgets" },
                   new Category() { Id = 4, Name = "Musical Instruments" }
            );

            // Seed Data for Product
            List<Product> productsToSeed = new List<Product>();
            int categoryId = 1;
            for (int x = 1; x <= 100; x++)
            {
                productsToSeed.Add(
                        new Product()
                        {
                            Id = x,
                            CategoryId = categoryId = 1,
                            Name = string.Format("Product {0}-{1}", x, DateTime.Now.ToString("yyyyMMddHHmmss")),
                            Description = string.Format("This description is for product {0}-{1}", x, DateTime.Now.ToString("yyyyMMddHHmmss")),
                            Price = 1.99m
                        });
                categoryId++;
                if (categoryId > 4)
                    categoryId = 1;
            }


            builder.Entity<Product>().HasData(productsToSeed);
        }

        // DbSets
        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
