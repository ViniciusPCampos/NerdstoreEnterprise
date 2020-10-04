using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NSE.Core.Data;

namespace NSE.Catalog.API.Data
{
    public class CatalogContext : DbContext, IUnitOfWork
    {
        public Task<bool> Commit()
        {
            throw new System.NotImplementedException();
        }
    }
}