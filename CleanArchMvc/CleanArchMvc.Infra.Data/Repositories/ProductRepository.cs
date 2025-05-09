using CleanArchMvc.Infra.Data.Context;
using CleanArchMvcDomain.Entities;
using CleanArchMvcDomain.Interfaces;
using Microsoft.EntityFrameworkCore;

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
            //return await _productContext.Products.FindAsync(id);
            return await _productContext.Products.Include(c => c.Category)
            .SingleOrDefaultAsync(p => p.Id == id);
        }

        //public async Task<Product> GetProductCategoryAsync(int? id)
        //{
        //    return await _productContext.Products.Include(c => c.Category)
        //    .SingleOrDefaultAsync(p => p.Id == id);
        //}

        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await _productContext.Products.ToListAsync();
        }

        public async Task<Product> Remove(Product Product)
        {
            if (Product == null)
                throw new InvalidOperationException("Produto já foi removido ou não existe.");

            try
            {
                await _productContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw new InvalidOperationException("Erro de concorrência ao tentar excluir. O produto pode ter sido modificado ou excluído por outro processo.");
            }

            _productContext.Remove(Product);
            await _productContext.SaveChangesAsync();
            return Product;
        }

        public async Task<Product> Update(Product Product)
        {
            _productContext.Update(Product);
            await _productContext.SaveChangesAsync();
            return Product;
        }
    }
}
