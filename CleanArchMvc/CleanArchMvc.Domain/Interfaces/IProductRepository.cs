using CleanArchMvcDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvcDomain.Interfaces
{
    internal interface IProductRepository
    {
        Task<IEnumerable<Product>> GetCategories();
        Task<Product> GetbyId(int? id);

        Task<Product> Create(Product Product);
        Task<Product> Update(Product Product);
        Task<Product> Remove(Product Product);
    }
}
