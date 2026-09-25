using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PresentShop.Core.Entities;

namespace PresentShop.Infrastructure
{
    public class PresentShopDbContext: IdentityDbContext
    {
        public PresentShopDbContext(DbContextOptions<PresentShopDbContext> options):base(options){ }

        public DbSet<Item> Items { get; set; }
        public DbSet<Box> Boxes { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<BoxItem> BoxItems { get; set; }
        public DbSet<BoxSize> BoxSizes { get; set; }
        public DbSet<CartBox> CartBoxes { get; set; }
        public DbSet<OrderBox> OrderBoxes { get; set; }

    }
}
