using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Application.ViewModels.Products
{
    public class VM_Create_Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public  DateTime UpdateDate { get; set; }
    }
}
