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
    public class PdfFileReadRepository : ReadRepository<PdfFile>, IPdfFileReadRepository
    {
        public PdfFileReadRepository(WebAPIDbContext context) : base(context)
        {
        }
    }
}
