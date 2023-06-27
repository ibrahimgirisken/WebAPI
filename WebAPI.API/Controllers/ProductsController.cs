using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using WebAPI.Application.Features.Commands.Product.CreateProduct;
using WebAPI.Application.Features.Commands.Product.RemoveProduct;
using WebAPI.Application.Features.Commands.Product.UpdateProduct;
using WebAPI.Application.Features.Commands.ProductImageFile.UploadProductImage;
using WebAPI.Application.Features.Queries.Product.GetAllProduct;
using WebAPI.Application.Features.Queries.Product.GetByIdProduct;
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
