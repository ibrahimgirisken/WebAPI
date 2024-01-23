﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Application.DTOs.CategoryDTOs
{
    public class CategoryDto
    {
        public string Image1 { get; set; }
        public Guid? ParentId { get; set; }
        public int OrderNumber { get; set; }
        public bool Status { get; set; } = true;
        public List<CategoryTranslationsDto> Translations { get; set; }
    }
}
