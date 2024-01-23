using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Application.DTOs.CategoryDTOs;
using WebAPI.Application.DTOs.ProductDTOs;
using WebAPI.Domain.Entities;

namespace WebAPI.Application.MappingConfiguration
{
    public class GeneralProfile:Profile
    {
        public GeneralProfile()
        {
            CreateMap<ProductTranslations, AddProductTranslationsDto>().ReverseMap();
            CreateMap<ProductTranslations, ProductTranslationListDto>().ReverseMap();
            CreateMap<Product, AddProductDto>().ReverseMap();
            CreateMap<Product, ProductListDto>().ReverseMap();

            CreateMap<Category, AddCategoryDto>().ReverseMap();
            CreateMap<CategoryTranslations, AddCategoryTranslationsDto>().ReverseMap();
            CreateMap<Category, CategoryListDto>().ReverseMap();
            CreateMap<CategoryTranslations, CategoryTranslationsListDto>().ReverseMap();
        }
    }
}
