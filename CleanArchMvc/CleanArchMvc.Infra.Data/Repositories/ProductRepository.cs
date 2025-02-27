using CleanArchMvc.Infra.Data.Context;
using CleanArchMvcDomain.Entities;
using CleanArchMvcDomain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Infra.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        ApplicationDBContext _productContext;
        public ProductRepository(ApplicationDBContext context)
        {
            _productContext = context;
        }

        public async Task<Product> CreateAsync(Product product)
        {
            _productContext.Add(product);
            _productContext.SaveChangesAsync();
            return product;
        }

        public async Task<Product> GetbyIdAsync(int? id)
        {
            return await _productContext.products.FindAsync(id);
        }

        public async Task<Product> GetProductCategoryAsync(int? id)
        {
            //eager loading
            return await _productContext.products.Include(c => c.Category).
                SingleOrDefaultAsync(p => p.Id == id);
        }

        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            return await _productContext.products.ToListAsync();
        }

        public async Task<Product> RemoveAsync(Product product)
        {
            _productContext.Remove(product);
            await _productContext.SaveChangesAsync();
            return product;
        }

        public async Task<Product> UpdateAsync(Product product)
        {
            _productContext.Update(product);
            await _productContext.SaveChangesAsync();
            return product;
        }
    }
}
