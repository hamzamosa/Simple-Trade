using Microsoft.EntityFrameworkCore;
using MySimpleTrader.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySimpleProject.EntityFrameWork
{
    public class MySimpleTraderDbContext :DbContext
    {
       

        public DbSet<User> TbUsers { get; set; }
        public DbSet<Account> TbAcounts { get; set; }
        public DbSet<AssestTransAction> TbAssestTransAction { get; set; }

        public MySimpleTraderDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AssestTransAction>().OwnsOne(e=>e.Stock);

            base.OnModelCreating(modelBuilder);
        }
    
    }
}
