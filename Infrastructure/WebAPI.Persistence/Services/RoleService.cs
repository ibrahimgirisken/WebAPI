using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Application.Abstractions.Services;
using WebAPI.Domain.Entities.Identity;

namespace WebAPI.Persistence.Services
{
    public class RoleService : IRoleService
    {
        readonly RoleManager<AppRole> _roleManager;

        public RoleService(RoleManager<AppRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public async Task<bool> CreateRole(string name)
        {
            IdentityResult result=await _roleManager.CreateAsync(new() {Id=Guid.NewGuid().ToString(), Name = name });
            return result.Succeeded;
        }

        public async Task<bool> DeleteRole(string id)
        {
           AppRole appRole=await _roleManager.FindByIdAsync(id);
            IdentityResult result=await _roleManager.DeleteAsync(appRole);
            return result.Succeeded;
        }

        public (object, int) GetAllRoles(int page, int size)
        {
            var query = _roleManager.Roles;
            IQueryable<AppRole> roleQuery = null;
            if (page!=-1&size!=-1) 
            {
                roleQuery= query.Skip(page*size).Take(size);
            }
            roleQuery = query;
            return (roleQuery.Select(r => new{r.Id,r.Name }),query.Count());

        }

        public async Task<(string id, string name)> GetRoleById(string id)
        {
           string role =await _roleManager.GetRoleIdAsync(new() { Id=id});
            return (id, role);
        }

        public Task<bool> UpdateRole(string id, string name)
        {
            throw new NotImplementedException();
        }
    }
}
