using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Application.Repositories;
using WebAPI.Domain.Entities;
using WebAPI.Persistence.Contexts;

namespace WebAPI.Persistence.Repositories
{
    public class CategoryReadRepository : ReadRepository<Category>, ICategoryReadRepository
    {
        public CategoryReadRepository(WebAPIDbContext context) : base(context)
        {
        }
    }
}
