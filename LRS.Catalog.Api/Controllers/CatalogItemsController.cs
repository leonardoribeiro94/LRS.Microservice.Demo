using LRS.Catalog.Api.Domain.Contracts.Services;
using Microsoft.AspNetCore.Mvc;

namespace LRS.Catalog.Api.Controllers
{

    [Route("api/v1/Catalog/items")]
    public class CatalogItemsController : ControllerBase
    {
        private readonly ICatalogItemService _CatalogItemsService;

        public CatalogItemsController(ICatalogItemService catalogItemsService)
        {
            _CatalogItemsService = catalogItemsService;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAllItems()
        {
            var catalogItems = await _CatalogItemsService.GetAllCatalogItems();

            return Ok(catalogItems);
        }


        [HttpGet]
        [Route("All")]
        public async Task<IActionResult> Items([FromQuery] int pageSize = 10, [FromQuery] int pageIndex = 0)
        {
            var catalogItems = await _CatalogItemsService.GetPaginatedCatalogItems(pageSize, pageIndex);

            return Ok(catalogItems);
        }
    }
}
