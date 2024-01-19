using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Domain.Entities.Common;

namespace WebAPI.Domain.Entities
{
    public class ProductTranslations:BaseEntity
    {
        public string Name { get; set; }
        public string PageTitle { get; set; }
        public string Content { get; set; }
        public string Url { get; set; }
        public string LanguageCode { get; set; }
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
    }
}
