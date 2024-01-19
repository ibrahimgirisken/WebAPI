using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using WebAPI.Application.Features.Commands.ProductEntity.CreateProduct;
using WebAPI.Application.Features.Commands.ProductEntity.RemoveProduct;
using WebAPI.Application.Features.Commands.ProductEntity.UpdateProduct;
using WebAPI.Application.Features.Commands.ProductImageFile.UploadProductImage;
using WebAPI.Application.Features.Queries.ProductEntity.GetAllProduct;
using WebAPI.Application.Features.Queries.ProductEntity.GetByIdProduct;
using WebAPI.Application.Repositories;
using WebAPI.Application.ViewModels.Products;
using WebAPI.Domain.Entities;

namespace WebAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes= "Admin")]
    public class ProductsController : ControllerBase
    {

        readonly IMediator _mediator;
        public ProductsController(IMediator mediator = null)
        {
            _mediator = mediator;
        }


        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetAllProductQueryRequest getAllProductCommandRequest)
        {
            GetAllProductQueryResponse response= await _mediator.Send(getAllProductCommandRequest);
            return Ok(response);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> Get([FromBody] GetByIdProductQueryRequest getByIdProductQueryRequest)
        {
            GetByIdProductQueryResponse response= await _mediator.Send(getByIdProductQueryRequest);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateProductCommandRequest createProductCommandRequest)
        {
            CreateProductCommandResponse response= await _mediator.Send(createProductCommandRequest);
            return Ok(response);
        }
        [HttpPut]

        public async Task<IActionResult> Update([FromBody] UpdateProductCommandRequest _updateProductCommandRequest)
        {
           UpdateProductCommandResponse response= await _mediator.Send(_updateProductCommandRequest);
            return Ok(response);
            
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete([FromRoute] RemoveProductCommandRequest removeProductCommandRequest)
        {
            await _mediator.Send(removeProductCommandRequest);
            return Ok();
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Upload(UploadProductImageCommandRequest uploadProductImageCommandRequest)
        {
            await _mediator.Send(uploadProductImageCommandRequest);
            return Ok();
        }
    }
}
