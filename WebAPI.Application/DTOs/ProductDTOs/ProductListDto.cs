using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Domain.Entities;

namespace WebAPI.Application.DTOs.ProductDTOs
{
    public class ProductListDto
    {
        public Guid Id { get; set; }
        public string ProductCode { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string Image3 { get; set; }
        public string Image4 { get; set; }
        public string Image5 { get; set; }
        public int OrderNumber { get; set; } = 1;
        public bool Status { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
        public List<ProductTranslationListDto> Translations { get; set; }
    }
}
