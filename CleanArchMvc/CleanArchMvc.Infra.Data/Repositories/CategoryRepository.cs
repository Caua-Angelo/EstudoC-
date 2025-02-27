using System;
using System.Collections.Generic;
using System.Linq;
using CleanArchMvcDomain.Entities;
using System.Text;
using System.Threading.Tasks;
using CleanArchMvc.Infra.Data.Context;
using CleanArchMvcDomain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CleanArchMvc.Infra.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        ApplicationDBContext _categoryContext;
        public CategoryRepository(ApplicationDBContext context)
        {
            _categoryContext = context;
        }
        public async Task<Category> Create(Category category)
        {
            _categoryContext.Add(category);
            await _categoryContext.SaveChangesAsync();
            return category;
        }
        public async Task<Category> GetbyId(int? id)
        {
            return await _categoryContext.categories.FindAsync(id);

        }
        public async Task<IEnumerable<Category>> GetCategories()
        {
            return await _categoryContext.categories.ToListAsync();
        }
        public async Task<Category> Remove(Category category)
        {
            _categoryContext.Remove(category);
            await _categoryContext.SaveChangesAsync();
            return category;
        }


        public async Task<Category> Update(Category category)
        {
            _categoryContext.Update(category);
            await _categoryContext.SaveChangesAsync();
            return category;
        }
    }
}

