using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Application.DTOs;
using WebAPI.Domain.Common.Result;
using WebAPI.Domain.Entities;

namespace WebAPI.Application.Features.Queries.ProductEntity.GetAllProduct
{
    public class GetAllProductQueryResponse
    {
        public List<Product> Products { get; set; }
    }
}
