using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Context
{
    public class ApplicationContext : DbContext
    {
   
        
            public ApplicationContext(DbContextOptions<ApplicationContext> option) : base(option)
            {

            }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }   
        
        public DbSet<Item> Items { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Cart>  Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<ItemReview> ItemReviews { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Staff> Staffs { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles{ get; set; }


    }
}
