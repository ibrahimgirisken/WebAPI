using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Domain.Entities.Common;

namespace WebAPI.Domain.Entities
{
    public class Slider:BaseEntity
    {
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string Image3 { get; set; }
        public int OrderNumber { get; set; }
        public bool Status { get; set; } = true;
        public virtual ICollection<SliderTranslations> Translations { get; set; }

    }
}
