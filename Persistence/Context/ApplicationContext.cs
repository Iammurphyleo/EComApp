using Domain.Constant;
using Domain.DTO;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.EntityConfiguraions;
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
            modelBuilder.ApplyConfiguration(new ProductEntityConfiguration());
            modelBuilder.ApplyConfiguration(new RoleEntityConfigurations());
        }   
        
        public DbSet<Product> Products {get; set;}
        public DbSet<Brand> Brands {get; set;}
        public DbSet<Category> Categories {get; set;}
        public DbSet<Order> Orders {get; set;}
        public DbSet<Payment> Payments {get; set;}
        public DbSet<Review> ProductReviews {get; set;}
        public DbSet<Role> Roles {get; set;}
        public DbSet<User> Users {get; set;}
        public DbSet<UserRole> UserRoles{get; set;}


    }
}
