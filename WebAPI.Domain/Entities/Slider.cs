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
        public string? Name { get; set; }
        public string? Url { get; set; }
        public string? Description { get; set; }
        public int OrderNumber { get; set; }
        public bool Status { get; set; }

    }
}
