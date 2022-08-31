using LRS.Catalog.Api.Domain.Contracts.Repositories;
using LRS.Catalog.Api.Domain.Contracts.Services;
using LRS.Catalog.Api.Domain.Entities;
using LRS.Catalog.Api.ViewModels;

namespace LRS.Catalog.Api.Services
{
    public class CatalogItemService : ICatalogItemService
    {
        private readonly ICatalogItemRepository _catalogItemRepository;

        public CatalogItemService(ICatalogItemRepository catalogItemRepository)
        {
            _catalogItemRepository = catalogItemRepository;
        }

   
        public async Task<IEnumerable<CatalogItem>> GetAllCatalogItems()
        {
            return await _catalogItemRepository.GetAll();
        }

        public async Task<PaginatedItemsViewModel<CatalogItem>> GetPaginatedCatalogItems(int pageSize, int pageIndex)
        {
            var catalogItems = await _catalogItemRepository.GetAll();

            var totalItems = catalogItems.Count();

            var itemsOnPage = catalogItems
                .OrderBy(c => c.Name)
                .Skip(pageSize * pageIndex)
                .Take(pageSize)
                .ToList();

            var model = new PaginatedItemsViewModel<CatalogItem>(
                pageIndex, pageSize, totalItems, itemsOnPage);

            return model;
        }
    }
}
