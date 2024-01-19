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

namespace WebAPI.Application.Features.Commands.CategoryEntity.CreateCategory
{
    public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommandRequest, IDataResult>
    {
        readonly ICategoryWriteRepository _categoryWriteRepository;
        readonly IMapper _mapper;

        public CreateCategoryCommandHandler(ICategoryWriteRepository categoryWriteRepository, IMapper mapper)
        {
            _categoryWriteRepository = categoryWriteRepository;
            _mapper = mapper;
        }

        public async Task<IDataResult> Handle(CreateCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            List<CategoryTranslations> categoryTranslations = _mapper.Map<List<CategoryTranslations>>(request.Category.CategoryTranslations);
            await _categoryWriteRepository.AddAsync(
                new()
                {
                    Image1=request.Category.Image1,
                    Name=request.Category.Name,
                    OrderNumber=request.Category.OrderNumber,
                    Status=request.Category.Status,
                    CreatedDate=new DateTime(),
                    UpdatedDate=new DateTime(),
                    Translations=categoryTranslations
                });
            await _categoryWriteRepository.SaveAsync();
            return await Task.FromResult<IDataResult>(new SuccessResult(ResultMessages.Category_Added));
        }
    }
}