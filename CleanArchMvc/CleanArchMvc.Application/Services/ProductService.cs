using AutoMapper;
using CleanArchMvc.Application.DTOS;
using CleanArchMvc.Application.Interfaces;
using CleanArchMvc.Application.Products.Queries;
using CleanArchMvcDomain.Entities;
using CleanArchMvcDomain.Interfaces;
using MediatR;

namespace CleanArchMvc.Application.Services
{
    public class ProductService : IProductService
    {

        private readonly IMediator _mediator;

        private readonly IMapper _mapper;
        public ProductService(IMapper mapper,IMediator mediator)
        {
            _mediator = mediator;
             
            _mapper = mapper;
        }
        public async Task<IEnumerable<ProductDTO>> GetProducts()
        {
            //var productsEntity = await _productRepository.GetProducts();
            //return _mapper.Map<IEnumerable<ProductDTO>>(productsEntity);
            var productsQuery = new GetProductsQuery();

            if (productsQuery == null)
                throw new Exception("Entity could not be loaded");

            var result = await _mediator.Send(productsQuery);
            
            return _mapper.Map<IEnumerable<ProductDTO>>(result);
        }

        //public async Task<ProductDTO> GetById(int? id)
        //{
        //    var productEntity = await _productRepository.GetbyId(id);
        //    return _mapper.Map<ProductDTO>(productEntity);
        //}

        //public async Task<ProductDTO> GetProductCategory(int? id)
        //{
        //    var productEntity = await _productRepository.GetProductCategoryAsync(id);
        //    return _mapper.Map<ProductDTO>(productEntity);
        //}

        //public async Task Add(ProductDTO productDto)
        //{
        //    var productEntity = _mapper.Map<Product>(productDto);
        //    await _productRepository.Create(productEntity);
        //}

        //public async Task Update(ProductDTO productDto)
        //{
        //    var productEntity = _mapper.Map<Product>(productDto);
        //    await _productRepository.Update(productEntity);
        //}

        //public async Task Remove(int? id)
        //{
        //    var productEntity = _productRepository.GetbyId(id).Result;
        //    await _productRepository.Remove(productEntity);

        //}
    }
}
