using LRS.Catalog.Api.Entities;
using LRS.Catalog.Api.Infra.Mappings;
using Microsoft.EntityFrameworkCore;

namespace LRS.Catalog.Api.Infra.Context
{
    public class CatalogContext : DbContext
    {
        public CatalogContext(DbContextOptions<CatalogContext> options)
        {

        }

        public DbSet<CatalogItem> CatalogItems { get; set; }
        public DbSet<CatalogBrand> CatalogBrands { get; set; }
        public DbSet<CatalogType> CatalogTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CatalogItemMap());
            modelBuilder.ApplyConfiguration(new CatalogBrandMap());
            modelBuilder.ApplyConfiguration(new CatalogItemMap());
        }
    }
}
