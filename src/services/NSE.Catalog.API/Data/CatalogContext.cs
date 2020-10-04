using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NSE.Core.Data;

namespace NSE.Catalog.API.Data
{
    public class CatalogContext : DbContext, IUnitOfWork
    {
        public async  Task<bool> Commit()
        {
            return await SaveChangesAsync() > 0;
        }
    }
}