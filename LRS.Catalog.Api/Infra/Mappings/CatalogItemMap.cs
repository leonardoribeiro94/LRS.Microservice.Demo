using LRS.Catalog.Api.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LRS.Catalog.Api.Infra.Mappings
{
    public class CatalogItemMap : IEntityTypeConfiguration<CatalogItem>
    {
        public void Configure(EntityTypeBuilder<CatalogItem> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(50);

            builder.Property(x => x.Description)
               .HasColumnType("varchar")
               .HasMaxLength(50);

            builder.Property(x => x.PictureFileName)
               .IsRequired()
               .HasColumnType("varchar")
               .HasMaxLength(5);

            builder.HasOne(cb => cb.CatalogBrand)
                 .WithOne(ci => ci.CatalogItem)
                 .HasForeignKey<CatalogItem>(x => x.CatalogBrandId);

            builder.HasOne(ct => ct.CatalogType)
                 .WithOne(ci => ci.CatalogItem)
                 .HasForeignKey<CatalogItem>(x => x.CatalogTypeId);
        }
    }
}
