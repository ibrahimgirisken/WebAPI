using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Domain.Entities.Common;

namespace WebAPI.Domain.Entities
{
    public class BlogTranslations:BaseEntity
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public string Brief { get; set; }
        public string MetaDescription { get; set; }
        public string PageTitle { get; set; }
        public string Content { get; set; }
        public virtual ICollection< MyProperty { get; set; }
    }
}
