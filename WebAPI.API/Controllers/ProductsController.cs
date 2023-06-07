using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Application.Repositories;
using WebAPI.Application.ViewModels.Products;
using WebAPI.Domain.Entities;

namespace WebAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        readonly private IProductReadRepository _productReadRepository;

        readonly private IProductWriteRepository _productWriteRepository;
        public ProductsController(IProductReadRepository productReadRepository, IProductWriteRepository productWriteRepository)
        {
            this._productReadRepository = productReadRepository;
            this._productWriteRepository = productWriteRepository;
        }


        [HttpGet]
        public async Task get()
        {
            await productWriteRepository.AddRangeAsync(new()
            {
                new(){Id=Guid.NewGuid(),Description="test-1",Name="Product-1",CreatedDate=DateTime.Now},
                new(){Id=Guid.NewGuid(),Description="test-2",Name="Product-2",CreatedDate=DateTime.Now},
                new(){Id=Guid.NewGuid(),Description="test-3",Name="Product-3",CreatedDate=DateTime.Now},
                new(){Id=Guid.NewGuid(),Description="test-4",Name="Product-4",CreatedDate=DateTime.Now}
            });
            await productWriteRepository.SaveAsync();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> getById(string id)
        {
           var response= await productReadRepository.GetByIdAsync(id);
            return Ok(response);
        }
        [HttpPost]
        public async Task<IActionResult> add(Product product)
        {
          var response= productWriteRepository.AddAsync(product);
            await productWriteRepository.SaveAsync();
            return Ok(response);
        }
    }
}
