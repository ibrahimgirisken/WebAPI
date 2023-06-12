using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
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
        public async Task<IActionResult> getAll()
        {
          var data= _productReadRepository.GetAll();
            return Ok(data);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> getById(string id)
        {
           var response= await _productReadRepository.GetByIdAsync(id);
            return Ok(response);
        }
        [HttpPost]
        public async Task<IActionResult> add(VM_Create_Product model)
        {
           await _productWriteRepository.AddAsync(
                new()
                {
                    Name = model.Name,
                    Description = model.Description,
                    CreatedDate=DateTime.Now
                }
            );
          var result= await _productWriteRepository.SaveAsync();
            return Ok(result);
        }
    }
}
