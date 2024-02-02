using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Application.Features.Commands.AppUser.CreateUser;
using WebAPI.Application.Features.Commands.AppUser.LoginUser;
using WebAPI.Application.Features.Queries.AppUser.GetAllUser;

namespace WebAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        readonly IMediator _mediator;

        public AuthController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Login(LoginUserCommandRequest loginUserCommandRequest)
        {
            LoginUserCommandResponse response= await _mediator.Send(loginUserCommandRequest);
            return Ok(response);
        }

    }
}
