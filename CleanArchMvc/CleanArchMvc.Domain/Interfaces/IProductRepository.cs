using CleanArchMvcDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvcDomain.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProducts();
        Task<Product> GetbyId(int? id);
        Task<Product> GetProductCategoryAsync(int? id);
        Task<Product> Create(Product Product);
        Task<Product> Update(Product Product);
        Task<Product> Remove(Product Product);
    }
}
