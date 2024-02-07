using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Application.Abstractions.Services;

namespace WebAPI.Application.Features.Commands.Role.CreateRole
{
    public class CreateRoleCommandHandler : IRequestHandler<CreateRoleCommandRequest, CreateRoleCommandResponse>
    {
        readonly IRoleService _roleService;

        public CreateRoleCommandHandler(IRoleService roleService)
        {
            _roleService = roleService;
        }

        async Task<CreateRoleCommandResponse> IRequestHandler<CreateRoleCommandRequest, CreateRoleCommandResponse>.Handle(CreateRoleCommandRequest request, CancellationToken cancellationToken)
        {

            var result = await _roleService.CreateRole(request.Name);
            return new()
            {
                Succeeded=result
            };
        }
    }
}
