using CleanArchMvcDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvcDomain.Interfaces
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetProductsAsync();
        Task<Category> CreateAsync(Category category);
        Task<Product> GetbyIdAsync(int? id);
        Task<Category> UpdateAsync(Category category);
        Task<Category> RemoveAsync(Category category);
    }
}
