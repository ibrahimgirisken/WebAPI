using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Application.DTOs.CategoryDTOs;
using WebAPI.Application.DTOs.ProductDTOs;
using WebAPI.Application.Repositories;
using WebAPI.Domain.Entities;

namespace WebAPI.Application.Features.Queries.CategoryEntity.GetAllCategory
{
    public class GetAllCategoryQueryHandler : IRequestHandler<GetAllCategoryQueryRequest, GetAllCategoryQueryResponse>
    {
        readonly ICategoryReadRepository _categoryReadRepository;
        readonly IMapper _mapper;

        public GetAllCategoryQueryHandler(IMapper mapper, ICategoryReadRepository categoryReadRepository)
        {
            _mapper = mapper;
            _categoryReadRepository = categoryReadRepository;
        }

        public async Task<GetAllCategoryQueryResponse> Handle(GetAllCategoryQueryRequest request, CancellationToken cancellationToken)
        {
            List<Category> categories = _categoryReadRepository.GetAll().Include(i => i.Translations).ToList();
            List<CategoryListDto> categoryDtos = _mapper.Map<List<CategoryListDto>>(categories);

            return new()
            {
                Categories = categoryDtos,
            };
        }
    }
}
