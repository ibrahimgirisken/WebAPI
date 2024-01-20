using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Domain.Common.Result;

namespace WebAPI.Application.Features.Commands.ProductEntity.CreateProduct
{
    public class CreateProductCommandResponse
    {
        public string Message { get; set; }
        public bool IsSuccess { get; set; }
    }
}
