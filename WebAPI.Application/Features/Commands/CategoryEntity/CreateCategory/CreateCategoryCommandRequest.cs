﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Application.DTOs.CategoryDTOs;

namespace WebAPI.Application.Features.Commands.CategoryEntity.CreateCategory
{
    public class CreateCategoryCommandRequest:IRequest<CreateCategoryCommandResponse>
    {
        public AddCategoryDto Category{ get; set; }
    }
}
