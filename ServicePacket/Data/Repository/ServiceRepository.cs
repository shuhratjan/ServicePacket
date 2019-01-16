using Microsoft.EntityFrameworkCore;
using ServicePacket.Data.Interface;
using ServicePacket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicePacket.Data.Repository
{
    public class ServiceRepository : Repository<Service>, IServiceRepository
    {
        public ServiceRepository(ApplicationDbContext context):base(context)
        {   
        }
        public IEnumerable<Service> FindWithCategory(Func<Service, bool> predicate)
        {
            return _context.Services.Include(c => c.Category).Where(predicate);
        }
        
        public IEnumerable<Service> GetAllWithCategory()
        {
            return _context.Services.Include(c => c.Category);
        }
    }
}
