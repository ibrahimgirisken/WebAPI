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
        readonly private IProductReadRepository productReadRepository;

        readonly private IProductWriteRepository productWriteRepository;
        public ProductsController(IProductReadRepository productReadRepository, IProductWriteRepository productWriteRepository)
        {
            this.productReadRepository = productReadRepository;
            this.productWriteRepository = productWriteRepository;
        }


        [HttpGet]
        public async Task<IActionResult> getAll()
        {
            var response = productReadRepository.GetAll();
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> getById(string id)
        {
            var response = await productReadRepository.GetByIdAsync(id);
            return Ok(response);
        }
        [HttpPost]
        public async Task<IActionResult> add(VM_Create_Product model)
        {
            Product responseProduct = new Product
            {
                Name = model.Name,
                Description = model.Description
            };
            var response = await productWriteRepository.AddAsync(responseProduct);
            await productWriteRepository.SaveAsync();
            return Ok(response);
        }
    }
}
