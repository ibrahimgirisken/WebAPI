﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Application.Repositories;
using WebAPI.Domain.Entities.Common;
using WebAPI.Persistence.Contexts;

namespace WebAPI.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        private WebAPIDbContext _context;

        public ReadRepository(WebAPIDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll(bool tracking = true)
        {
            var query = Table.AsQueryable();
            if (!tracking)

                query = query.AsNoTracking();
            return query;
        }

        public IQueryable<T> GetAllWithRelatedData(bool tracking = true, params Expression<Func<T, object>>[] includeProperties)
        {
            var query = Table.AsQueryable();
            if (!tracking)
                query = query.AsNoTracking();

            // İlişkili tabloyu (navigasyon property) sorguya dahil et
            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }

            return query;
        }

        public async Task<T> GetByIdAsync(string id, bool tracking = true)
        {
            var query=Table.AsQueryable();
            if(!tracking)
                query=query.AsNoTracking();
            return await query.FirstOrDefaultAsync(data => data.Id == Guid.Parse(id));
        }

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method, bool tracking = true)
        {
            var query = Table.AsQueryable();
            if(!tracking)
                query=query.AsNoTracking();
            return await query.FirstOrDefaultAsync(method);
        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method, bool tracking = true)
        {
            var query = Table.Where(method);
            if (!tracking)
                query = query.AsNoTracking();
            return query;
        }
    }
}
