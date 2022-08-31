using LRS.Catalog.Api.Domain.Contracts.Repositories;
using LRS.Catalog.Api.Domain.Entities;
using LRS.Catalog.Api.Infra.Context;
using Microsoft.EntityFrameworkCore;

namespace LRS.Catalog.Api.Infra.Repositories
{
    public class CatalogItemRepository : ICatalogItemRepository
    {
        protected readonly CatalogContext Db;
        protected readonly DbSet<CatalogItem> DbSet;

        public CatalogItemRepository(CatalogContext db)
        {
            Db = db;
            DbSet = db.Set<CatalogItem>();
        }

        public async Task<IEnumerable<CatalogItem>> GetAll()
        {
            return await DbSet.AsNoTracking().ToListAsync();
        }
    }
}
