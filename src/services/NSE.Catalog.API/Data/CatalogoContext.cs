﻿using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace NSE.Catalog.API.Data
{
    public class CatalogoContext : DbContext
    {
        public CatalogoContext(DbContextOptions<CatalogoContext> options):base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var property in modelBuilder.Model.GetEntityTypes().SelectMany(
                e => e.GetProperties().Where(p => p.ClrType == typeof(string))))
            {
                property.SetColumnType("varchar(100)");
            }

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CatalogoContext).Assembly);
        }
    }
}