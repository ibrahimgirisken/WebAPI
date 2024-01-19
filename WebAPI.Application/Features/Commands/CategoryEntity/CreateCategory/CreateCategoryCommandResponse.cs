using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Domain.Common.Result;

namespace WebAPI.Application.Features.Commands.CategoryEntity.CreateCategory
{
    public class CreateCategoryCommandResponse : IDataResult
    {
        public string Message { get; set; }
        public bool IsSuccess { get; set; }
    }
}
