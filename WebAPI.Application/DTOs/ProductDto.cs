using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Domain.Entities;

namespace WebAPI.Application.DTOs
{
    public class ProductDto
    {
        public string ProductCode { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string Image3 { get; set; }
        public string Image4 { get; set; }
        public string Image5 { get; set; }
        public int OrderNumber { get; set; } = 1;
        public bool Status { get; set; }
        public List<ProductTranslationsDto> Translations { get; set; }
    }
}
