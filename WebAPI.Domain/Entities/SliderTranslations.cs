using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Domain.Entities.Common;

namespace WebAPI.Domain.Entities
{
    public class SliderTranslations:BaseEntity
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public string Content { get; set; }
        public Slider Slider { get; set; }
        public Guid SliderId { get; set; }
    }
}
