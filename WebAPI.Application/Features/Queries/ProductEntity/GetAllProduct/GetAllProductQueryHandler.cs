using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
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
            List<Product> products = _mapper.Map<List<Product>>(_productReadRepository.GetAll());
            return new()
            {
                Products = products,

            };
        }
    }
}
