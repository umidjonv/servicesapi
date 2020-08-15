using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using productsapi.Entities;
using productsapi.Entities.Log;
using productsapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace productsapi.Data
{
    public class ProductContext: DbContext
    {
        
        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }

        public DbSet<Image> Image { get; set; }

        public DbSet<EntityLog> Entity { get; set; }

        public ProductContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            var cat = modelBuilder.HasPostgresExtension("uuid-ossp").Entity<Category>();
            cat.HasMany(c => c.products).WithOne(p => p.category);
                
                cat.Property(e => e.id).HasDefaultValueSql("uuid_generate_v4()");
                cat.Property(e => e.status).HasDefaultValue(true).ValueGeneratedOnAdd();

            var prod = modelBuilder.HasPostgresExtension("uuid-ossp").Entity<Product>();
                prod.Property(e => e.id).HasDefaultValueSql("uuid_generate_v4()");
                prod.Property(e => e.status).HasDefaultValue(true).ValueGeneratedOnAdd();
            prod.HasOne(p => p.category).WithMany(c=>c.products);

            var img = modelBuilder.HasPostgresExtension("uuid-ossp").Entity<Image>();
            img.Property(e => e.id).HasDefaultValueSql("uuid_generate_v4()");
            img.Property(e => e.status).HasDefaultValue(true).ValueGeneratedOnAdd();


            modelBuilder.Entity<EntityLog>()
                .Property(b => b.created_at)
                  .HasColumnType("timestamp without time zone")
                  .HasDefaultValueSql("CURRENT_TIMESTAMP")
                  .ValueGeneratedOnAdd();

            modelBuilder.Entity<EntityLog>()
                .Property(b => b.updated_at)
                .HasColumnType("timestamp without time zone")
                  .HasDefaultValueSql("CURRENT_TIMESTAMP")
                  .ValueGeneratedOnAddOrUpdate();

            modelBuilder.Entity<EntityLog>()
                .Property(b => b.status)
                .HasDefaultValue(true);
                






            //modelBuilder.Entity<Product>()
            //    .Property(b => b.updated_at)
            //    .HasDefaultValueSql("now()")
            //    .ValueGeneratedOnAddOrUpdate();


        }
    }
}
