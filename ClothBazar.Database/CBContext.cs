using ClothBazar.Entites;
using System;
using System.Data.Entity;

namespace ClothBazar.Database
{
    public class CBContext : DbContext, IDisposable
    {
        public CBContext() : base("ClothBazarConnection")
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Config> Configurations { get; set; }
    }
}
