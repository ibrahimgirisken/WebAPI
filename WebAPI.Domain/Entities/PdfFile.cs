using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Domain.Entities
{
    public class PdfFile:File
    {
        public string PdfProductCode { get; set; }
    }
}
