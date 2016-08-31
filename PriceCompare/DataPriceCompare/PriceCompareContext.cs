using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataPriceCompare
{
    public class PriceCompareContext : DbContext
    {
        protected DbSet<Item> Items { get; set; }
        public DbSet<Store> Stores { get; set; }

        public PriceCompareContext()
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>().HasKey(item => new { item.ID });
            modelBuilder.Entity<Store>().HasKey(store => new { store.ID});

            modelBuilder.Entity<Item>().Property(item => item.ID).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Store>().Property(store => store.ID).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            base.OnModelCreating(modelBuilder);
        }


    }
}
