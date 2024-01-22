using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Application.Features.Commands.CategoryEntity.CreateCategory;
using WebAPI.Application.Features.Queries.CategoryEntity.GetAllCategory;
using WebAPI.Application.Repositories;
using WebAPI.Application.ViewModels.Category;

namespace WebAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        readonly IMediator _mediator;

        public CategoriesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetAllCategoryQueryRequest getAllCategoryQueryRequest)
        {
            GetAllCategoryQueryResponse response =await _mediator.Send(getAllCategoryQueryRequest);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateCategoryCommandRequest createCategoryCommandRequest)
        {
            CreateCategoryCommandResponse response = await _mediator.Send(createCategoryCommandRequest);
            return Ok(response);
        }
    }
}
