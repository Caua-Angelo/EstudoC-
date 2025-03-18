using AutoMapper;
using CleanArchMvc.Application.DTOS;
using CleanArchMvc.Application.Interfaces;
using CleanArchMvcDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Application.Services
{
    public class CategoryService : ICategoryService
    {
        private ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;
        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CategoryDTO>> GetCategories()
        {
            var categoriesEntity = _categoryRepository.GetCategories();
        }

        public async Task<IEnumerable<CategoryDTO>> GetById(int? id)
        {
            throw new NotImplementedException();
        }

        public async Task Add(CategoryDTO categoryDto)
        {
            throw new NotImplementedException();
        }

        public async Task Update(CategoryDTO categoryDto)
        {
            throw new NotImplementedException();
        }

        public async Task Remove(int? id)
        {
            throw new NotImplementedException();
        }
    }
}
