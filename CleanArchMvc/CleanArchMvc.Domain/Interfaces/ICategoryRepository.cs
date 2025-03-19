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
        Task<IEnumerable<Category>> GetCategories();
        Task<Category> Create(Category category);
        Task<Category> GetbyId(int? id);
        Task<Category> Update(Category category);
        Task<Category> Remove(Category category);
    }
}
