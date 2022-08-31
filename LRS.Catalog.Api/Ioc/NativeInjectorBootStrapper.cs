using LRS.Catalog.Api.Domain.Contracts.Repositories;
using LRS.Catalog.Api.Domain.Contracts.Services;
using LRS.Catalog.Api.Infra.Repositories;
using LRS.Catalog.Api.Services;

namespace LRS.Catalog.Api.Ioc
{
    public static class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection service)
        {
            service.AddScoped<ICatalogItemRepository, CatalogItemRepository>();
            service.AddScoped<ICatalogItemService, CatalogItemService>();
        }
    }
}
