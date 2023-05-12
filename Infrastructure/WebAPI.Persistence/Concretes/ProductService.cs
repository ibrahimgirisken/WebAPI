using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Application.Abstractions;
using WebAPI.Domain.Entities;

namespace WebAPI.Persistence.Concretes
{
    public class ProductService : IProductService
    {
        public List<Product> GetProduct()
        => new()
        {
            new()
            {
                Id=Guid.NewGuid(),
                CreatedDate = DateTime.Now,
                Name="Product1",
                Description="Test data1"
            },
            new()
            {
                Id=Guid.NewGuid(),
                CreatedDate = DateTime.Now,
                Name="Product2",
                Description="Test data2"
            },
            new()
            {
                Id=Guid.NewGuid(),
                CreatedDate = DateTime.Now,
                Name="Product3",
                Description="Test data3"
            },
            new()
            {
                Id=Guid.NewGuid(),
                CreatedDate = DateTime.Now,
                Name="Product4",
                Description="Test data4"
            },
            new()
            {
                Id=Guid.NewGuid(),
                CreatedDate = DateTime.Now,
                Name="Product5",
                Description="Test data5"
            }
        };
    }
}
