using Microsoft.EntityFrameworkCore;
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
    public class ProductReadRepository : ReadRepository<Product>, IProductReadRepository
    {
        public ProductReadRepository(WebAPIDbContext context) : base(context)
        {
        }

        public IQueryable<Product> GetAllWithRelatedData(bool tracking = true)
        {
            var query = Table.AsQueryable();

            if (!tracking)
                query = query.AsNoTracking();

            // Include metodu ile ilişkili verileri sorguya dahil et
            query = query.Include(p => p.Translations);

            return query;
        }
    }
}
