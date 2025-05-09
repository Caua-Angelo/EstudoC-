﻿using CleanArchMvc.Application.Products.Commands;
using CleanArchMvcDomain.Entities;
using CleanArchMvcDomain.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Application.Products.Handlers
{
    public class ProductRemoveCommandHandler : IRequestHandler<ProductRemoveCommand, Product>
    {
        private readonly IProductRepository _productRepository;
        public ProductRemoveCommandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
        }
        public async Task<Product> Handle(ProductRemoveCommand request, CancellationToken cancellationToken)
        {
            var product = await _productRepository.GetbyId(request.Id);

            if (product == null)
            {
                throw new ApplicationException("Entity could not be created");
            }
            else
            {
                var result = await _productRepository.Remove(product);

                return await _productRepository.Update(product);
            }
        }
    }
}