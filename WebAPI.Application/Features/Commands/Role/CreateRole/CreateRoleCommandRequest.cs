﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Application.Features.Commands.Role.CreateRole
{
    internal class CreateRoleCommandRequest:IRequest<CreateRoleCommandResponse>
    {
    }
}