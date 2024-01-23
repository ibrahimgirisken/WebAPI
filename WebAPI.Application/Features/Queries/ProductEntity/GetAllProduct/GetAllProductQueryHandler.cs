using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using WebAPI.Application.DTOs.ProductDTOs;
using WebAPI.Application.Repositories;
using WebAPI.Domain.Entities;

namespace WebAPI.Application.Features.Queries.ProductEntity.GetAllProduct
{
    public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQueryRequest, GetAllProductQueryResponse>
    {
        readonly IProductReadRepository _productReadRepository;
        readonly IMapper _mapper;

        public GetAllProductQueryHandler(IProductReadRepository productReadRepository, IMapper mapper)
        {
            _productReadRepository = productReadRepository;
            _mapper = mapper;
        }

        public async Task<GetAllProductQueryResponse> Handle(GetAllProductQueryRequest request, CancellationToken cancellationToken)
        {
            List<Product> products=_productReadRepository.GetAll().Include(i=>i.Translations).ToList();
            List<ProductListDto> productDtos = _mapper.Map<List<ProductListDto>>(products);

            return new()
            {
                Products = productDtos,

            };
        }
    }
}
