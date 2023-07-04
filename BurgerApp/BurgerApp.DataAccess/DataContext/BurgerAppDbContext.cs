using BurgerApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace BurgerApp.DataAccess.DataContext
{
    public class BurgerAppDbContext : DbContext
    {
        public DbSet<Burger> Burgers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<User> Users { get; set; }

        public BurgerAppDbContext(DbContextOptions dbContextOptions) :
        base(dbContextOptions)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Order>()
                .HasMany(x => x.OrderBurgers)
                .WithOne(x => x.Order)
                .HasForeignKey(x => x.OrderId);

            modelBuilder.Entity<Burger>()
                .HasMany(x => x.OrderBurgers)
                .WithOne(x => x.Burger)
                .HasForeignKey(x => x.BurgerId);

            modelBuilder.Entity<User>()
                .HasMany(x => x.Orders)
                .WithOne(x => x.User)
                .HasForeignKey(x => x.UserId);

            modelBuilder.Entity<Burger>()
                .HasData(
                new Burger
                {
                    Id = 1,
                    Name = "Hamburger",
                    Description = "Beef patty, Buns, Ketchup, Mayo, Lettuce",
                    Price = 250,
                    IsVegan = false,
                    IsVegeterian = false,
                    HasFries = true,
                },
                new Burger
                {
                    Id = 2,
                    Name = "Cheeseburger",
                    Description = "Beef patty, Cheddar, Buns, Ketchup, Mayo, Lettuce",
                    Price = 300,
                    IsVegan = false,
                    IsVegeterian = false,
                    HasFries = true,
                },
                new Burger
                {
                    Id = 3,
                    Name = "Chikenburger",
                    Description = "Chiken steak, Buns, Ketchup, Mayo, Lettuce",
                    Price = 350,
                    IsVegan = false,
                    IsVegeterian = false,
                    HasFries = true,
                },
                new Burger
                {
                    Id = 4,
                    Name = "Chiken Cheese",
                    Description = "Chiken steak, Cheddar, Buns, Ketchup, Mayo, Lettuce",
                    Price = 280,
                    IsVegan = false,
                    IsVegeterian = false,
                    HasFries = true,
                }
            );
        }
    }
}
}
