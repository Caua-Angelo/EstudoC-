using CleanArchMvcDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvcDomain.Interfaces
{
    internal interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetProductsAsync();
        Task<Product> GetbyIdAsync(int? id);

        Task<Category> CreateAsync(Category category);
        Task<Category> UpdateAsync(Category category);
        Task<Category> RemoveAsync(Category category);
    }
}
