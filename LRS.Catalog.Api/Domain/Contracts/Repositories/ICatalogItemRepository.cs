using LRS.Catalog.Api.Domain.Entities;

namespace LRS.Catalog.Api.Domain.Contracts.Repositories
{
    public interface ICatalogItemRepository
    {
        public Task<IEnumerable<CatalogItem>> GetAll();
    }
}
