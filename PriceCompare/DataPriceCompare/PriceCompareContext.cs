using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DataPriceCompare
{
    public class PriceCompareContext : DbContext
    {
        public DbSet<Item> Items { get; set; }
        public DbSet<Store> Stores { get; set; }

        public PriceCompareContext()
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>().HasKey(item => item.Code);
            modelBuilder.Entity<Store>().HasKey(store => store.)
            base.OnModelCreating(modelBuilder);
        }


    }
}
