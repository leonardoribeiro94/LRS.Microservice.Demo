namespace LRS.Catalog.Api.Entities
{
    public class CatalogType
    {
        public int Id { get; set; }
        public string TypeName { get; set; }
        public CatalogItem CatalogItem { get; set; }
    }
}
