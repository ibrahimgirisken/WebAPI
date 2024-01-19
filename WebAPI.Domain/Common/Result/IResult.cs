using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Domain.Common.Result
{
    public interface IDataResult
    {
        public string Message { get; set; }
        public bool IsSuccess { get; set; }
    }
}
