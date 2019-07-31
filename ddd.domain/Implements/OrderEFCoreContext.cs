using System;
using System.Collections.Generic;
using System.Text;
using ddd.domain.dbentity;
using ddd.domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ddd.domain.Implements
{
    public class OrderEFCoreContext : DbContext, IOrderContext
    {
        public DbSet<Orders> Order { get; set; }
        public DbSet<OrderItem> OrderItem { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {

            optionBuilder.UseSqlServer("数据库连接字符串");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Orders>().OwnsOne(p => p.OrderStreet);
            modelBuilder.Entity<Orders>().OwnsOne(p => p.OrderTotalPrice);
            modelBuilder.Entity<Orders>().OwnsOne(p => p.OrderTotalPV);

            modelBuilder.Entity<OrderItem>().OwnsOne(p => p.OrderItemTotalPrice);
            modelBuilder.Entity<OrderItem>().OwnsOne(p => p.OrderItemTotalPV);
            modelBuilder.Entity<OrderItem>().OwnsOne(p => p.ProductSKUs);
        }
    }
}
