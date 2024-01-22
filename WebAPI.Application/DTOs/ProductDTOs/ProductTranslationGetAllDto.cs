using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Application.DTOs.ProductDTOs
{
    public class ProductTranslationGetAllDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string PageTitle { get; set; }
        public string Content { get; set; }
        public string Url { get; set; }
        public string LanguageCode { get; set; }
    }
}
