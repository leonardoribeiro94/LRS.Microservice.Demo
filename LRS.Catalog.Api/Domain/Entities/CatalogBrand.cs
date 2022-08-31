namespace LRS.Catalog.Api.Domain.Entities
{
    public class CatalogBrand
    {
        public int Id { get; set; }
        public string BrandName { get; set; }
        public CatalogItem CatalogItem { get; set; }
    }
}
