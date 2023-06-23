using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Application.Features.Queries.Category.GetAllCategory
{
    public class GetAllCategoryQueryRequest:IRequest<GetAllCategoryQueryResponse>
    {
    }
}
