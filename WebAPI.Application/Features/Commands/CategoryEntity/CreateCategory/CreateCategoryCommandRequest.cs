using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Application.DTOs;

namespace WebAPI.Application.Features.Commands.CategoryEntity.CreateCategory
{
    public class CreateCategoryCommandRequest:IRequest<CreateCategoryCommandResponse>
    {
        public CategoryDto Category{ get; set; }
    }
}
