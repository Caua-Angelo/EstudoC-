using AutoMapper;
using CleanArchMvc.Application.DTOS;
using CleanArchMvc.Application.Interfaces;
using CleanArchMvcDomain.Entities;
using CleanArchMvcDomain.Interfaces;
using System.Collections.Generic;

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
            var categoriesEntity = await _categoryRepository.GetCategories();
            return _mapper.Map<IEnumerable<CategoryDTO>>(categoriesEntity);
        }

        public Task<CategoryDTO> GetById(int? id)
        {
            throw new NotImplementedException();
        }

        public Task Add(CategoryDTO categoryDto)
        {
            throw new NotImplementedException();
        }

        public Task Update(CategoryDTO categoryDto)
        {
            throw new NotImplementedException();
        }

        public Task Remove(int? id)
        {
            throw new NotImplementedException();
        }
    }
}
