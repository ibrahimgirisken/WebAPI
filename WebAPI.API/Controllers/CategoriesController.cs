using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Application.Features.Queries.Category.GetAllCategory;
using WebAPI.Application.Repositories;
using WebAPI.Application.ViewModels.Category;

namespace WebAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        readonly ICategoryReadRepository _categoryReadRepository;
        readonly ICategoryWriteRepository _categoryWriteRepository;
        readonly IMediator _mediator;

        public CategoriesController(ICategoryReadRepository categoryReadRepository, ICategoryWriteRepository categoryWriteRepository, IMediator mediator = null)
        {
            _categoryReadRepository = categoryReadRepository;
            _categoryWriteRepository = categoryWriteRepository;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get(GetAllCategoryQueryRequest getAllCategoryQueryRequest)
        {
            GetAllCategoryQueryResponse response =await _mediator.Send(getAllCategoryQueryRequest);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Post(VM_Create_Category model)
        {
           var response=await _categoryWriteRepository.AddAsync(
               new()
               {
                   Name=model.Name,
                   OrderNumber=model.OrderNumber,
                   Status=model.Status,
                   ParentId=model.ParentId,
                   Url=model.Url
               }
               );
            await _categoryWriteRepository.SaveAsync();
            return Ok(response);
        }
    }
}
