using ClothBazar.Entites;
using System.Data.Entity;

namespace ClothBazar.Database
{
    class CBContext : DbContext
    {
        public CBContext() : base("ClothBazarConnection")
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
