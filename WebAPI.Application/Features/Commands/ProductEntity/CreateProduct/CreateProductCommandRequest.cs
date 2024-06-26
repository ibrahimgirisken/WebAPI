﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Application.DTOs.ProductDTOs;
using WebAPI.Domain.Entities;

namespace WebAPI.Application.Features.Commands.ProductEntity.CreateProduct
{
    public class CreateProductCommandRequest:IRequest<CreateProductCommandResponse>
    {
        public AddProductDto Product { get; set; }
    }
}
