using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Domain.Entities.Common;

namespace WebAPI.Domain.Entities
{
    public class Category:BaseEntity
    {
        public string Image1 { get; set; }
        public Guid? ParentId { get; set; }
        public int OrderNumber { get; set; }
        public bool Status { get; set; }
        public ICollection<CategoryTranslations> Translations { get; set; }
    }
}
