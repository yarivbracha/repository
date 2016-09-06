﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataPriceCompare
{
    public class PriceCompareContext : DbContext
    {
        public DbSet<Item> Items { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<User> Users { get; set; }

        private static PriceCompareContext instance;

        private PriceCompareContext() : base("PrimeCompareDB")
        {
            Database.SetInitializer<PriceCompareContext>(null);
        }

        public static PriceCompareContext Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PriceCompareContext();
                }
                return instance;
            }
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>().HasKey(item => new { item.Id });
            modelBuilder.Entity<Store>().HasKey(store => new { store.Id});
            modelBuilder.Entity<User>().HasKey(user => new { user.Id });
            modelBuilder.Entity<User>().Property(user => user.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Item>().Property(item => item.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Store>().Property(store => store.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            base.OnModelCreating(modelBuilder);
        }


    }
}
