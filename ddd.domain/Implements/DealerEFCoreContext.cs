using System;
using System.Collections.Generic;
using System.Text;
using ddd.domain.dbentity;
using ddd.domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ddd.domain.Implements
{
    public class DealerEFCoreContext: DbContext, IDealerContext
    {
        public DbSet<Dealers> Dealer { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<DealerTree> DealerTree { get; set; }
        public DbSet<Login> Login { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer("数据库连接字符串");
        }
    }
}
