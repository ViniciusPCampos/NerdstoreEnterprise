using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NSE.Catalog.API.Models;

namespace NSE.Catalog.API.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly CatalogoContext _context;

        public ProductRepository(CatalogoContext context)
        {
            _context = context;
        }

        public void Dispose()
        {
            _context?.Dispose();
        }

        public async Task<IEnumerable<Product>> GetAll()
        {
            return await _context.Set<Product>().AsNoTracking().ToListAsync();
        }

        public async Task<Product> GetById(Guid id)
        {
            return await _context.Set<Product>().FindAsync(id);
        }

        public void Add(Product product)
        {
            _context.Set<Product>().Add(product);
        }

        public void Update(Product product)
        {
            _context.Set<Product>().Update(product);
        }
    }
}