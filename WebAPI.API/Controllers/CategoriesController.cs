using Microsoft.AspNetCore.Mvc;
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

        public CategoriesController(ICategoryReadRepository categoryReadRepository, ICategoryWriteRepository categoryWriteRepository)
        {
            _categoryReadRepository = categoryReadRepository;
            _categoryWriteRepository = categoryWriteRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var data=_categoryReadRepository.GetAll();
            return Ok(data);
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
