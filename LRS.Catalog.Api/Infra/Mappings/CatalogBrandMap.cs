using LRS.Catalog.Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LRS.Catalog.Api.Infra.Mappings
{
    public class CatalogBrandMap : IEntityTypeConfiguration<CatalogBrand>
    {
        public void Configure(EntityTypeBuilder<CatalogBrand> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.BrandName)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(50);
        }
    }
}
