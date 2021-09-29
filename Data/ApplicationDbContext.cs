using ExpressDLL.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Text;

namespace TritonExpress.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Vehicle>(entity =>
            //{
            //    // Set key for entity
            //    entity.HasKey(p => p.VehicleId);
            //});

            //modelBuilder.Entity<Item>(entity =>
            //{
            //    // Set key for entity
            //    entity.HasKey(p => p.ItemId);
            //});

            //modelBuilder.Entity<Parcel>(entity =>
            //{
            //    // Set key for entity
            //    entity.HasKey(p => p.ParcelId);
            //});

            //modelBuilder.Entity<Waybill>(entity =>
            //{
            //    // Set key for entity
            //    entity.HasKey(p => p.WaybillId);
            //});

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Item> Items { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Parcel> Parcels { get; set; }
        public DbSet<Waybill> Waybills { get; set; }
    }
}
