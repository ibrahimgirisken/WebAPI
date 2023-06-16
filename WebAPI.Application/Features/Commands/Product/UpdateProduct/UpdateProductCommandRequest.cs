using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Application.Features.Commands.Product.UpdateProduct
{
    public class UpdateProductCommandRequest:IRequest<UpdateProductCommandResponse>
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

    }
}
