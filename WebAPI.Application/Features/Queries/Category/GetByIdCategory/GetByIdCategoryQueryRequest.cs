using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Application.Features.Queries.Category.GetByIdCategory
{
    public class GetByIdCategoryQueryRequest:IRequest<GetByIdCategoryQueryResponse>
    {
    }
}
