using Azure.Core;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Application.Abstractions.Services;
using WebAPI.Application.DTOs.User;
using WebAPI.Application.Exceptions;
using WebAPI.Domain.Entities.Identity;

namespace WebAPI.Persistence.Services
{
    public class UserService : IUserService
    {
        readonly UserManager<AppUser> _userManager;

        public UserService(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<CreateUserResponse> CreateAsync(CreateUser model)
        {
            IdentityResult result = await _userManager.CreateAsync(new()
            {
                Id = Guid.NewGuid().ToString(),
                UserName = model.UserName,
                Email = model.Email,
                NameSurname = model.NameSurname
            }, model.Password);
            CreateUserResponse response = new() { Succeeded = result.Succeeded};
            if (response.Succeeded)
            {
                response.Message = "Kullanıcı başarı ile oluşturulmuştur";
            }
            throw new UserCreatedFailedException();
        }
    }
}
