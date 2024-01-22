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
            CreateMap<ProductTranslations, ProductTranslationsDto>().ReverseMap();
            CreateMap<ProductTranslations, ProductTranslationGetAllDto>().ReverseMap();
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<Product, ProductGetAllDto>().ReverseMap();

            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<CategoryTranslations, CategoryTranslationsDto>().ReverseMap();
            CreateMap<Category, CategoryGetAllDto>().ReverseMap();
            CreateMap<CategoryTranslations, CategoryTranslationsGetAllDto>().ReverseMap();
        }
    }
}
