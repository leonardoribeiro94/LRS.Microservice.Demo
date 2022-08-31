using LRS.Catalog.Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LRS.Catalog.Api.Infra.Mappings
{
    public class CatalogTypeMap : IEntityTypeConfiguration<CatalogType>
    {
        public void Configure(EntityTypeBuilder<CatalogType> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.TypeName)
                .IsRequired()
                .HasColumnType("varchar");
        }
    }
}
