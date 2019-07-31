using ddd.domain.dbentity;
using ddd.domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ddd.domain.Implements
{
    public class ProductEFCoreContext : DbContext, IProductContext
    {
        public DbSet<ProductSPU> ProductSPU { get; set; }
        public DbSet<ProductSKU> ProductSKU { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer("数据库连接字符串");
        }
    }
}
