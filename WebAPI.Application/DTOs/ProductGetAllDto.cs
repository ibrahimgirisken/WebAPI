using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Application.DTOs
{
    public class ProductGetAllDto
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
        public List<ProductTranslationGetAllDto> Translations { get; set; }
    }
}
