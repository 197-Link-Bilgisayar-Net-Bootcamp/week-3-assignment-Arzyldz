using Microsoft.EntityFrameworkCore;

namespace NLayer.DAL.Models
{
    public class ApDataContext:DbContext
    {
        public ApDataContext(DbContextOptions<ApDataContext> options) : base(options)
        { 
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductFeature> ProductFeatures { get; set; }
        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    base.OnModelCreating(builder);
        //}
    }
}
