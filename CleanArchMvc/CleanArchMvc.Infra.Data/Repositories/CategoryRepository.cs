using System;
using System.Collections.Generic;
using System.Linq;
using CleanArchMvcDomain.Entities;
using System.Text;
using System.Threading.Tasks;
using CleanArchMvc.Infra.Data.Context;
using CleanArchMvcDomain.Interfaces;

namespace CleanArchMvc.Infra.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        ApplicationDBContext _categoryContext;
        public CategoryRepository(ApplicationDBContext context)
        {
            _categoryContext = context;
        }

        public async Task<Category> CreateAsync(Category category)
        {
            _categoryContext.Add(category);
            await _categoryContext.SaveChangesAsync();
            return category;
        }

        public async Task<Product> GetbyIdAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Category>> GetProductsAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Category> RemoveAsync(Category category)
        {
            throw new NotImplementedException();
        }

        public async Task<Category> UpdateAsync(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
