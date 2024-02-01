﻿using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Application.Abstractions.Services;
using WebAPI.Application.DTOs.User;
using WebAPI.Application.Exceptions;

namespace WebAPI.Application.Features.Commands.AppUser.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommandRequest, CreateUserCommandResponse>
    {
        readonly IUserService _userService;

        public CreateUserCommandHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<CreateUserCommandResponse> Handle(CreateUserCommandRequest request, CancellationToken cancellationToken)
        {

          CreateUserResponse response=await _userService.CreateAsync(new()
            {
                UserName = request.UserName,
                Email = request.Email,
                NameSurname=request.NameSurname,
                Password = request.Password,
                PasswordConfirm = request.PasswordConfirm
            });

            return new()
            {
                Message = response.Message,
                Succeeded = response.Succeeded,
            };
        }
    }
}
