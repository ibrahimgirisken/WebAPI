﻿using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Application.Repositories;
using WebAPI.Domain.Common.Result;
using WebAPI.Domain.Constants;
using WebAPI.Domain.Entities;

namespace WebAPI.Application.Features.Commands.ProductEntity.CreateProduct
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommandRequest, CreateProductCommandResponse>
    {
        readonly IProductWriteRepository _productWriteRepository;
        readonly IMapper _mapper;

        public CreateProductCommandHandler(IProductWriteRepository productWriteRepository, IMapper mapper)
        {
            _productWriteRepository = productWriteRepository;
            _mapper = mapper;
        }

        public async Task<CreateProductCommandResponse> Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
        {
            List<ProductTranslations> productTranslations = _mapper.Map<List<ProductTranslations>>(request.Product.Translations);
            await _productWriteRepository.AddAsync(
                new()
                {
                    ProductCode=request.Product.ProductCode,
                    Image1=request.Product.Image1,
                    Image2 = request.Product.Image2,
                    Image3 = request.Product.Image3,
                    Image4 = request.Product.Image4,
                    Image5 = request.Product.Image5,
                    CategoryId=request.Product.CategoryId,
                    OrderNumber=request.Product.OrderNumber,
                    Translations= productTranslations,
                    Status = request.Product.Status,
                    UpdatedDate = DateTime.UtcNow,
                    CreatedDate = DateTime.UtcNow

                });
            await _productWriteRepository.SaveAsync();
            return new() { IsSuccess = true, Message = ResultMessages.Product_Added };
        }
    }
}
