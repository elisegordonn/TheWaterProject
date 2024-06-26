﻿using Microsoft.EntityFrameworkCore;
namespace TheWaterProject.Models
{
    public class WaterProjectContext : DbContext
    {
        public WaterProjectContext (DbContextOptions<WaterProjectContext> options) : base(options) { }

        public DbSet<Project> Projects => Set<Project>();
        public DbSet<Order> Orders => Set<Order>();
        public DbSet<User> Users => Set<User>();
        public DbSet<OrderItem> order_items => Set<OrderItem>();
    }
}
