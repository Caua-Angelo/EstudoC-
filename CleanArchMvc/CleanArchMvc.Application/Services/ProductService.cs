﻿using AutoMapper;
using CleanArchMvc.Application.DTOS;
using CleanArchMvc.Application.Interfaces;
using CleanArchMvc.Application.Products.Commands;
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
        public ProductService(IMapper mapper, IMediator mediator)
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

        public async Task<ProductDTO> GetById(int? id)
        {
            var productByIdQuery = new GetProductByIdQuery(id.Value);

            if (productByIdQuery == null)
                throw new Exception("Entity could not be loaded");

            var result = await _mediator.Send(productByIdQuery);

            return _mapper.Map<ProductDTO>(result);
        }

        //public async Task<ProductDTO> GetProductCategory(int? id)
        //{
        //    var productByIdQuery = new GetProductByIdQuery(id.Value);

        //    if (productByIdQuery == null)
        //        throw new Exception("Entity could not be loaded");

        //    var result = await _mediator.Send(productByIdQuery);

        //    return _mapper.Map<ProductDTO>(result);
        //}

        public async Task Add(ProductDTO productDto)
        {
            var productCreateCommand = _mapper.Map<ProductCreateCommand>(productDto);
            await _mediator.Send(productCreateCommand);
        }

        public async Task Update(ProductDTO productDto)
        {
            var productUpdateCommand = _mapper.Map<ProductUpdateCommand>(productDto);
            await _mediator.Send(productUpdateCommand);
        }

        public async Task Remove(int? id)
        {
            var ProductRemoveCommand = new ProductRemoveCommand(id.Value);
            if (ProductRemoveCommand == null)
                throw new Exception("Entity could not be loaded");

            await _mediator.Send(ProductRemoveCommand); 
        }
    }
}
