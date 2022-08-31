using LRS.Catalog.Api.Domain.Entities;
using LRS.Catalog.Api.ViewModels;

namespace LRS.Catalog.Api.Domain.Contracts.Services
{
    public interface ICatalogItemService
    {
        public Task<PaginatedItemsViewModel<CatalogItem>> GetPaginatedCatalogItems(int pageSize, int pageIndex);  
        public Task<IEnumerable<CatalogItem>> GetAllCatalogItems();
    }
}
