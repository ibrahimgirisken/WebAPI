using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using WebAPI.Application.Features.Commands.Product.CreateProduct;
using WebAPI.Application.Features.Commands.Product.RemoveProduct;
using WebAPI.Application.Features.Commands.Product.UpdateProduct;
using WebAPI.Application.Features.Queries.Product.GetAllProduct;
using WebAPI.Application.Features.Queries.Product.GetByIdProduct;
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
        readonly IMediator _mediator;
        public ProductsController(IProductReadRepository productReadRepository, IProductWriteRepository productWriteRepository, IMediator mediator = null)
        {
            this._productReadRepository = productReadRepository;
            this._productWriteRepository = productWriteRepository;
            _mediator = mediator;
        }


        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetAllProductQueryRequest getAllProductCommandRequest)
        {
            GetAllProductQueryResponse response= await _mediator.Send(getAllProductCommandRequest);
            return Ok(response);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> Get([FromRoute] GetByIdProductQueryRequest getByIdProductQueryRequest)
        {
            GetByIdProductQueryResponse response= await _mediator.Send(getByIdProductQueryRequest);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateProductCommandRequest createProductCommandRequest)
        {
            CreateProductCommandResponse response= await _mediator.Send(createProductCommandRequest);
            return Ok(response);
        }
        [HttpPut]

        public async Task<IActionResult> Update(UpdateProductCommandRequest _updateProductCommandRequest)
        {
           UpdateProductCommandResponse response= await _mediator.Send(_updateProductCommandRequest);
            return Ok(response);
            
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> delete([FromRoute] RemoveProductCommandRequest removeProductCommandRequest)
        {
            await _mediator.Send(removeProductCommandRequest);
            return Ok();
        }
    }
}
