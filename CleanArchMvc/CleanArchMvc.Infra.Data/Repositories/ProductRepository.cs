using CleanArchMvcDomain.Interfaces;
using CleanArchMvc.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchMvcDomain.Entities;

namespace CleanArchMvc.Infra.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        ApplicationDBContext _productContext;

        public ProductRepository(ApplicationDBContext context)
        {
            _productContext = context;
        }

        public async Task<Product> Create(Product Product)
        {
            _productContext.Add(Product);
            await _productContext.SaveChangesAsync();
            return Product;
        }

        public async Task<Product> GetbyId(int? id)
        {
            return await _productContext.Products.FindAsync(id);
        }

        public async Task<Product> GetProductCategoryAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            throw new NotImplementedException();
        }

        public async Task<Product> Remove(Product Product)
        {
            throw new NotImplementedException();
        }

        public async Task<Product> Update(Product Product)
        {
            throw new NotImplementedException();
        }
    }
}
