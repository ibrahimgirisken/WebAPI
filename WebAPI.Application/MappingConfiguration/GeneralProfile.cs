using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Application.DTOs;
using WebAPI.Domain.Entities;

namespace WebAPI.Application.MappingConfiguration
{
    public class GeneralProfile:Profile
    {
        public GeneralProfile()
        {
            CreateMap<ProductTranslations, ProductTranslationsDto>().ReverseMap();
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<CategoryTranslations, CategoryTranslationsDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
        }
    }
}
