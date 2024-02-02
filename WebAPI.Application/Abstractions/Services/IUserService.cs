using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Application.DTOs.User;

namespace WebAPI.Application.Abstractions.Services
{
    public interface IUserService
    {
        Task<CreateUserResponse> CreateAsync(CreateUser model);
        Task<List<ListUser>> GetAllUsersAsync(int page, int size);
        Task<string[]> AssignRoleToUserAsync(string userId, string[] roles);
        Task<string[]> GetRolesToUser(string userIdOrName);
        int TotalUsersCount { get; }
    }
}
