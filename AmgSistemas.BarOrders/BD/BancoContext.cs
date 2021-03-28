﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AmgSistemas.BarOrders.BD
{
    public class BancoContext : DbContext
    {

        public DbSet<Models.AGBO_TEMPRESA> AGBO_TEMPRESA { get; set; }

        public DbSet<Models.AGBO_TFILIAL> AGBO_TFILIAL { get; set; }

        public DbSet<Models.AGBO_TGRUPO_PRODUTO> AGBO_TGRUPO_PRODUTO { get; set; }
        public DbSet<Models.AGBO_PRODUTO> AGBO_PRODUTO { get; set; }
        public DbSet<Models.AGBO_TPRODUTO_FILIAL> AGBO_TPRODUTO_FILIAL { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=h0ly2jiz8m.database.windows.net;Initial Catalog=IGERENCE;Persist Security Info=True;User ID=anselmo;Password=@mg110182");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                  .Entity<Models.AGBO_TEMPRESA>(eb =>
                  {
                      eb.HasKey("ID_EMPRESA");
                  });


            modelBuilder
                  .Entity<Models.AGBO_TFILIAL>(eb =>
                  {
                      eb.HasKey("ID_FILIAL");
                  });
            
            modelBuilder
                  .Entity<Models.AGBO_TGRUPO_PRODUTO>(eb =>
                  {
                      eb.HasKey("ID_GRUPO_PRODUTO");
                  }); 
            
            
            modelBuilder
                  .Entity<Models.AGBO_PRODUTO>(eb =>
                  {
                      eb.HasKey("ID_PRODUTO");
                  }); 
            modelBuilder
                  .Entity<Models.AGBO_TPRODUTO_FILIAL>(eb =>
                  {
                      eb.HasKey("ID_PRODUTO_FILIAL");
                  });

        }

    }
}
